using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using DVLD_Project.Global_Classes;
using System.IO;
namespace DVLD_Project
{
    public partial class frmAddNewPerson : Form
    {
        public delegate void DelDataBack(object sender, int PersonId);
        public event DelDataBack DataBack;
        public enum enGender { male = 0, female = 1 }
        public enum enMode { Addnew = 0, Update = 1 }
        private enMode _Mode = enMode.Addnew;
        private int _PersonID = -1;
        clsPersonB _Person;
        private void _FillCountriesinComboBox()
        {
            DataTable dtCountries = clsCountryB.GetAllCountries();
            foreach (DataRow drcountries in dtCountries.Rows)
            {
                cmboCountries.Items.Add(drcountries["CountryName"]);
            }
        }
        private void _ResetDefaultValues()
        {
            _FillCountriesinComboBox();
            if (_Mode == enMode.Addnew)
            {
                lblFormStatus.Text = "Add New Person";
                _Person = new clsPersonB();
            }
            else { lblFormStatus.Text = "Update Person "; }
            rdbtnMale.Checked = true;
            if (rdbtnMale.Checked)
            {
                PbPersonGenderImage.Image = Resources.Male_512;
            }
            else { PbPersonGenderImage.Image = Resources.Female_512; }
            lbllinkRemove.Visible = (PbPersonGenderImage.ImageLocation != null);
            //Start Age For licenses is 18Yo before now ;
            //so BD should be 'before (-)' Now around 18yo or more
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            //Licenses Not Allowed For People Greater Than 100yo ;
            //so BD should be 'lessThan' Now around 100yo or more
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            //Default Country
            cmboCountries.SelectedIndex = cmboCountries.FindString("Egypt");
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
        private void _LoadData()
        {
            _Person = clsPersonB.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            else
            {
                lblPersonIDResult.Text = _PersonID.ToString();
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName;
                txtLastName.Text = _Person.LastName;
                txtNationalNo.Text = _Person.NationalNo;
                dtpDateOfBirth.Text = _Person.BofDate.ToString();
                if (_Person.Gender == 0)
                    rdbtnMale.Checked = true;
                else
                    rdbtnFemale.Checked = true;
                txtEmail.Text = _Person.Email;
                txtPhone.Text = _Person.Phone;
                txtAddress.Text = _Person.Address;                    //countryInfoByComposition finding Country fullObject 
                if (_Person.CountryInfo != null)
                {
                    cmboCountries.SelectedIndex = cmboCountries.FindString(_Person.CountryInfo.CountryName);
                }
                if (PbPersonGenderImage != null)
                {
                    PbPersonGenderImage.ImageLocation = _Person.ImagePath;
                }

               // lbllinkRemove.Visible = (_Person.ImagePath != null);
                lbllinkRemove.Visible =(!string.IsNullOrEmpty(_Person.ImagePath));
            }
        }
        public frmAddNewPerson() //Add New  Mode
        {
            InitializeComponent();
            _Mode = enMode.Addnew;
        }
        public frmAddNewPerson(int PersonID) //Update  Mode
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }
        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                      "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Country = clsCountryB.Find(cmboCountries.Text);
            if (Country == null)
            {
                MessageBox.Show("Please select a valid country!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandlePersonImage())
            {
                return;
            }
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.BofDate = dtpDateOfBirth.Value;
            _Person.NationalityCountryID = Country.CountryID;
            _Person.Gender = (short)(rdbtnMale.Checked ? enGender.male : enGender.female);
            _Person.ImagePath = (PbPersonGenderImage.ImageLocation != null) ? PbPersonGenderImage.ImageLocation : "";

            if (_Person.Save())
            {
                lblPersonIDResult.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lblFormStatus.Text = "Update Person ";

                MessageBox.Show("Data Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
            {
                MessageBox.Show("Error: Data was not saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidateEmptytxtBox(object sender, CancelEventArgs e)
        {
            TextBox tempbox = (TextBox)sender;
            if (string.IsNullOrEmpty(tempbox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tempbox, "This Field Is Requierd");
            }
            else errorProvider1.SetError(tempbox, null);
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;
            if (!clsValidation.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Format");
            }
            else
                errorProvider1.SetError(txtEmail, null);

        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This Field Is Requierd");
                return;
            }
            else
                errorProvider1.SetError(txtNationalNo, null);

            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPersonB.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This National Number Is already Exist");
            }
            else
                errorProvider1.SetError(txtNationalNo, null);

        }
        private void rdbtnMale_Click(object sender, EventArgs e)
        {
            //if (PbPersonGenderImage.ImageLocation == null)
            //    PbPersonGenderImage.Image = Resources.Male_512;
            

            //true
            if (string.IsNullOrEmpty(PbPersonGenderImage.ImageLocation))
                PbPersonGenderImage.Image = Resources.Male_512;
        }
        private void rdbtnFemale_Click(object sender, EventArgs e)
        {
            //if (PbPersonGenderImage.ImageLocation == null)
            //    PbPersonGenderImage.Image = Resources.Female_512;
            if (string.IsNullOrEmpty(PbPersonGenderImage.ImageLocation))
            {
                PbPersonGenderImage.Image = Resources.Female_512;

            }
        }
        private void lbllinkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;
                PbPersonGenderImage.Load(SelectedFilePath);
                lbllinkRemove.Visible = true;
            }
        }
        private void lbllinkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PbPersonGenderImage.ImageLocation = null;

            if (rdbtnMale.Checked)
            {
                PbPersonGenderImage.Image = Resources.Male_512;
            }
            else
            {
                PbPersonGenderImage.Image = Resources.Female_512;
            }
            lbllinkRemove.Visible = false;
        }
        private bool _HandlePersonImage()
        {
            // التحقق لو الصورة اتغيرت فعلاً
            if (_Person.ImagePath != PbPersonGenderImage.ImageLocation)
            {
                // 1. معالجة حذف الصورة القديمة بأمان
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        // لو الصورة القديمة هي الصورة الافتراضية (Male/Female) متمسحهاش
                        // يفضل التأكد إنها مش ملف من ملفات المشروع الأساسية
                        if (File.Exists(_Person.ImagePath))
                        {
                            File.Delete(_Person.ImagePath);
                        }
                    }
                    catch (IOException ex)
                    {
                        // لو الملف محجوز، بنسجل الخطأ في الـ Debug بس مش بنوقف البرنامج
                        System.Diagnostics.Debug.WriteLine("Could not delete old image: " + ex.Message);
                    }
                }

                // 2. معالجة نسخ الصورة الجديدة
                if (!string.IsNullOrEmpty(PbPersonGenderImage.ImageLocation))
                {
                    string sourceFile = PbPersonGenderImage.ImageLocation;

                    if (clsUtil.CopyImageToProjectImagesFolder(ref sourceFile))
                    {
                        // تحديث الـ PictureBox بالمسار الجديد "الداخلي"
                        PbPersonGenderImage.ImageLocation = sourceFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error in Copying Picture", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
  
        //private bool _HandlePersonImage()
        //{
        //    if (_Person.ImagePath != PbPersonGenderImage.ImageLocation)
        //    {
        //        if (PbPersonGenderImage.ImageLocation!= string.IsNullOrEmpty())
        //        {
        //            try
        //            {
        //                File.Delete(_Person.ImagePath);
        //            }
        //            catch (IOException) { }
        //        }
        //        if (PbPersonGenderImage.ImageLocation != null) 
        //        {
        //            string sourceFile = PbPersonGenderImage.ImageLocation.ToString();
        //            if (clsUtil.CopyImageToProjectImagesFolder(ref sourceFile))
        //            {
        //                PbPersonGenderImage.ImageLocation = sourceFile;
        //                return true;
        //            }
        //            else 
        //            {
        //            MessageBox.Show("Error in Copying Picture ","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }
        //    }
        //    return true ;
        //}
    }
}
