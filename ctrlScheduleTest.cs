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
using DVLD_BusinessLayer;
using DVLD_Project.Global_Classes;
using DVLD_Project.Properties;

namespace DVLD_Project
{
    public partial class ctrlScheduleTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTimeSchedule = 1 };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;
        private clsTestTypesB.enTestType _TestType = clsTestTypesB.enTestType.VisionTest;
        private clsLocalDrivingLicenseApplicationsB _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestAppointmentB _TestAppointment;
        private int _TestAppointmentID = -1;
        public clsTestTypesB.enTestType TestType
        {
            get { return _TestType; }
            set
            {
                _TestType = value;
                switch (_TestType)
                {
                    case clsTestTypesB.enTestType.VisionTest:
                        grbTestType.Text = "Vision Test";
                        PicBoxTestTypes.Image = Resources.Vision_512;
                        break;
                    case clsTestTypesB.enTestType.WrittenTest:
                        grbTestType.Text = "Written Test";
                        PicBoxTestTypes.Image = Resources.Written_Test_512;
                        break;
                    case clsTestTypesB.enTestType.StreetTest:
                        grbTestType.Text = "Street Test";
                        PicBoxTestTypes.Image = Resources.driving_test_512;
                        break;
                }
            }

        }
        public ctrlScheduleTest()
        {
            InitializeComponent();
        }
        public void LoadInfo(int LocalDrivingLicenseID, int TestAppointmentID = -1)
        {
            if (TestAppointmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseID;
            _TestAppointmentID = TestAppointmentID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplicationsB.FindByLocalDrivingAppLicense(LocalDrivingLicenseID);
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            if (_LocalDrivingLicenseApplication.DoesAttendTestType(_TestType))
                _CreationMode = enCreationMode.RetakeTimeSchedule;

            else
                _CreationMode = enCreationMode.FirstTimeSchedule;

            if (_CreationMode == enCreationMode.RetakeTimeSchedule)
            {
                lblRFeesdResult.Text = clsApplicationTypesB.Find((int)clsApplicationsB.enApplicationType.RetakeTest).AppFees.ToString();
                grbRetakeTest.Enabled = true;
                lblTestTypeTitle.Text = "Schedule Retake test";
                lblRTestIDResult.Text = "0";
            }
            else
            {
                grbRetakeTest.Enabled = false;
                lblTestTypeTitle.Text = "Schedule test";
                lblRTestIDResult.Text = "0";
                lblRTestIDResult.Text = "N/A";
            }
            if (_Mode == enMode.AddNew)
            {
                lblFeesResult.Text = clsTestTypesB.Find(_TestType).TestTypeFees.ToString();
                dateTimePicker1.MinDate = DateTime.Now;
                lblRTestIDResult.Text = "N/A";
                _TestAppointment = new clsTestAppointmentB();
            }
            else
            {
                if (!_LoadTestAppointmentData())
                    return;
            }
            lblTotalResult.Text = (Convert.ToSingle(lblFeesResult.Text) + Convert.ToSingle(lblRFeesdResult.Text)).ToString();

            if (!_HandleActiveTestAppointmentConstraint())
                return;
            if (!_HandleAppointmentLockedConstraint())
                return;
            if (!_HandlePrviousTestConstraint())
                return;
        }
        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointmentB.Find(_TestAppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }
            lblFeesResult.Text = _TestAppointment.PaidFees.ToString();
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dateTimePicker1.MinDate = DateTime.Now;
            else
                dateTimePicker1.MinDate = _TestAppointment.AppointmentDate;
            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lblRFeesdResult.Text = "0";
                lblRTestIDResult.Text = "N/A";
            }
            else
            {
                grbRetakeTest.Enabled = true;
                lblTestTypeTitle.Text = "Schedule Retake test";
                lblRFeesdResult.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
                lblRTestIDResult.Text = _TestAppointment.RetakeTestApplicationID.ToString();

            }
            return true;
        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && clsLocalDrivingLicenseApplicationsB.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, _TestType))
            {
                lblmessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dateTimePicker1.Enabled = false;
                return false;
            }
            return true;
        }
        private bool _HandleAppointmentLockedConstraint()
        {
            //if appointment is locked that means the person already sat for this test
            //we cannot update locked appointment
            if (_TestAppointment.IsLocked)
            {
                lblmessage.Visible = true;
                lblmessage.Text = "Person already sat for the test, appointment loacked.";
                dateTimePicker1.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }
            else
                lblmessage.Visible = false;

            return true;
        }
        private bool _HandlePrviousTestConstraint()
        {
            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.
            switch (_TestType)
            {
                case clsTestTypesB.enTestType.VisionTest:
                    lblmessage.Enabled = false;
                    return true;

                case clsTestTypesB.enTestType.WrittenTest:
                    if (!_LocalDrivingLicenseApplication.DoesPassPreviousTest(clsTestTypesB.enTestType.VisionTest))
                    {
                        lblmessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblmessage.Visible = true;
                        btnSave.Enabled = false;
                        dateTimePicker1.Enabled = false;
                        return false;
                    }
                    else
                        lblmessage.Visible = false;
                    btnSave.Enabled = true;
                    dateTimePicker1.Enabled = true;

                    return true;
                case clsTestTypesB.enTestType.StreetTest:
                    if (!_LocalDrivingLicenseApplication.DoesPassPreviousTest(clsTestTypesB.enTestType.WrittenTest))
                    {
                        lblmessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lblmessage.Visible = true;
                        btnSave.Enabled = false;
                        dateTimePicker1.Enabled = false;
                        return false;
                    }
                    else
                        lblmessage.Visible = false;
                    btnSave.Enabled = true;
                    dateTimePicker1.Enabled = true;

                    return true;

            }
            return true;
        }
        private bool _HandleRetakeApplication()
        {
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTimeSchedule)
            {
                clsApplicationsB NewApplicantion = new clsApplicationsB();
                NewApplicantion.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                NewApplicantion.ApplicationDate = DateTime.Now;
                NewApplicantion.LastStatusDate = DateTime.Now;
                NewApplicantion.ApplicaionStatus = clsApplicationsB.enApplicaionStatus.Completed;
                NewApplicantion.PaidFees = clsApplicationTypesB.Find((int)clsApplicationsB.enApplicationType.RetakeTest).AppFees;
                NewApplicantion.ApplicationTypeID = (int)clsApplicationsB.enApplicationType.RetakeTest;
                NewApplicantion.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                if (!NewApplicantion.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _TestAppointment.RetakeTestApplicationID = NewApplicantion.ApplicationID;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestType;
            _TestAppointment.AppointmentDate = dateTimePicker1.Value;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.PaidFees = Convert.ToSingle(lblFeesResult.Text);
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_TestAppointment.Save())
            {

                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}