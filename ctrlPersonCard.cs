using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using DVLD_Project.Properties;

namespace DVLD_Project
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPersonB _Person;
        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } }
        public clsPersonB SelectedPersonInfo { get { return _Person; } } //return object _Person with Name "Selected Person Info"
        public ctrlPersonCard()
        {
            InitializeComponent();
        } //constructor
        public void ResetPersonInfo()
        {
            linkLabel1.Visible = false;
            _PersonID = -1; //If not -1 Still Full With PersonID
            lblPersonIDResultPI.Text = "[.......]";
            lblNamePI.Text = "[.......]";
            lblNationalPI.Text = "[.......]";
            lblGendorPI.Text = "[.......]";
            lblCountryPI.Text = "[.......]";
            lblEmailPI.Text = "[.......]";
            lblPhonePI.Text = "[.......]";
            lblAddressPI.Text = "[.......]";
            lblBDPI.Text = "[.......]";
            PbPersonGenderImagePI.Image = Resources.Male_512;
            pBoxGendor.Image = Resources.Man_32;
        }
        private void _LoadPersonImage() //Default Images (Resources) then if ImagePath Not Empty Check if Image Exist in Photos fill Pbox 
        {
            if (_Person.Gender == 0)
                PbPersonGenderImagePI.Image = Resources.Male_512;
            else
                PbPersonGenderImagePI.Image = Resources.Female_512;
            string imagePath = _Person.ImagePath;
            if (imagePath != "")
                if (File.Exists(imagePath))
                {
                    PbPersonGenderImagePI.ImageLocation = imagePath;
                }
                else
                    MessageBox.Show("Couldn't Find This Image " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _FillPersonInfo()
        {
            linkLabel1.Visible = true;
            _PersonID = _Person.PersonID; //not components only also _PersonID
            lblPersonIDResultPI.Text = _Person.PersonID.ToString();
            lblNamePI.Text = _Person.FullName;
            lblNationalPI.Text = _Person.NationalNo;
            //lblCountryPI.Text = _Person.CountryInfo.CountryName;
            lblCountryPI.Text = clsCountryB.Find(_Person.NationalityCountryID).CountryName;
            lblEmailPI.Text = _Person.Email;
            lblPhonePI.Text = _Person.Phone;
            lblAddressPI.Text = _Person.Address;
            lblBDPI.Text = _Person.BofDate.ToShortDateString();
            lblGendorPI.Text = _Person.Gender == 0 ? "Male" : "Female";
            _LoadPersonImage();
        }
        public void LoadPersonInfo(int PersonID) //Fill _Person (clsPesrson Object) With Find(Peroson ID) if null return else fill object
        {
            _Person = clsPersonB.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No person with PersonID :", PersonID.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        } 
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPersonB.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No person with NationalNo: :", NationalNo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
