using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Classes;
using DVLD_BusinessLayer;
using DVLD_Project.Global_Classes;

namespace DVLD_Project
{
    public partial class frmAddUpdateLocalApplication : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _LocalDrivingLicenseApplicationID = -1;
        //private int _SelectedPersonID = -1;
        clsLocalDrivingLicenseApplicationsB _LocalDrivingLicenseApplication;
        public frmAddUpdateLocalApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateLocalApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Mode = enMode.Update;
        }
        private void _FillLicenseClassesInComoboBox()
        {
            DataTable AllLicenses = clsLicenseClassesB.GetAllLicenseClasses();
            foreach (DataRow r in AllLicenses.Rows)
            {
                cmboLicensesClasses.Items.Add(r["ClassName"]);
            }
        }
        private void _ResetDefaultValues()
        {
            _FillLicenseClassesInComoboBox();
            if (_Mode == enMode.AddNew)
            {
                lblStatus.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplicationsB();
                ctrlPersonCardWithFilter1.FilterFocus();
                tbAppInfo.Enabled = false;

                lblAppDAteResult.Text = DateTime.Now.ToShortDateString();
                cmboLicensesClasses.SelectedIndex = 2;
               // cmboLicensesClasses.SelectedIndex = cmboLicensesClasses.FindString("Class 3 - Public and Light Vehicle");
                lblAPPFeesResult.Text = clsApplicationTypesB.Find((int)clsApplicationsB.enApplicationType.NewDrivingLicense).AppFees.ToString();
                lblCreatedByResult.Text = clsGlobal.CurrentUser.UserName;
            }
            else
            {
                lblStatus.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";
                tbAppInfo.Enabled = true;
                btnSave.Enabled = true;
            }
        }
        private void _LoadData()
        {

            ctrlPersonCardWithFilter1.FilterEnabled = false;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplicationsB.FindByLocalDrivingAppLicense(_LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            lblDLAPPResult.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblAppDAteResult.Text = clsFormat.DateToShort(_LocalDrivingLicenseApplication.ApplicationDate);
            cmboLicensesClasses.SelectedIndex = cmboLicensesClasses.FindString(clsLicenseClassesB.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName);
            lblAPPFeesResult.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lblCreatedByResult.Text = clsUserB.FindByUserId(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;
        }
        private void frmAddUpdateApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonID == -1) 
            {
                MessageBox.Show("Please Select a Person First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cmboLicensesClasses.SelectedIndex ==-1 || string.IsNullOrEmpty(cmboLicensesClasses.Text))
            {
                MessageBox.Show("Please select a License Class first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboLicensesClasses.Focus();
                return;
            }
            clsLicenseClassesB selectedClass = clsLicenseClassesB.Find(cmboLicensesClasses.Text);
           
            if (selectedClass == null)
            {
                MessageBox.Show("Error: License Class not found in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int LicenseClassId = selectedClass.LicenseClassID;
            int ActiveappID = clsApplicationsB.GetActiveApplicationIDForLicenseClass
                                    (ctrlPersonCardWithFilter1.PersonID, clsApplicationsB.enApplicationType.NewDrivingLicense, LicenseClassId);
            if (ActiveappID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveappID, "Error",
                                                                                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboLicensesClasses.Focus();
                return;
            }

            if (clsLicenseB.GetActiveLicenseIDByPersonID(ctrlPersonCardWithFilter1.PersonID, LicenseClassId) != -1)
            {
                MessageBox.Show("Person already has an active license for this class!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LocalDrivingLicenseApplication.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonID;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicaionStatus = clsApplicationsB.enApplicaionStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle(lblAPPFeesResult.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassId;
            if (_LocalDrivingLicenseApplication.Save())
            {
                lblDLAPPResult.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                _Mode = enMode.Update;
                lblStatus.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
        }
       
        private void frmAddUpdateLocalApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received
            ctrlPersonCardWithFilter1.LoadPersonInfo(PersonID);

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbAppInfo.Enabled = true;
                tb1.SelectedTab = tb1.TabPages["tbAppInfo"];
                return;
            }
            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {
                btnSave.Enabled = true;
                tbAppInfo.Enabled = true;
                tb1.SelectedTab = tb1.TabPages["tbAppInfo"];
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}