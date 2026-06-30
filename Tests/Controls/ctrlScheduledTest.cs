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
using DVLD_Project.Properties;

namespace DVLD_Project
{
    public partial class ctrlScheduledTest : UserControl
    {
        private clsLocalDrivingLicenseApplicationsB _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;

        private clsTestAppointmentB _TestAppointment;
        private int _TestAppointmentID = -1;
        public int TestAppointmentID { get { return _TestAppointmentID; } }

        private int _TestID = -1;
        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        private clsTestTypesB.enTestType _TestTypeID;
        public clsTestTypesB.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {
                    case clsTestTypesB.enTestType.VisionTest:
                        lblTestTypeTitle.Text = "Vision Test";
                        PicBoxTestTypes.Image = Resources.Vision_512;
                        break;
                    case clsTestTypesB.enTestType.WrittenTest:
                        lblTestTypeTitle.Text = "Written Test";
                        PicBoxTestTypes.Image = Resources.Written_Test_512;
                        break;
                    case clsTestTypesB.enTestType.StreetTest:
                        lblTestTypeTitle.Text = "Street Test";
                        PicBoxTestTypes.Image = Resources.driving_test_512;
                        break;
                }
            }
        }


        public ctrlScheduledTest()
        {
            InitializeComponent();
        }
        public void LoadInfo(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = clsTestAppointmentB.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }

            _TestID = _TestAppointment.TestID;
            this.TestTypeID = (clsTestTypesB.enTestType)_TestAppointment.TestTypeID;
            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplicationsB.FindByLocalDrivingAppLicense(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDLAppResult.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDClassResult.Text = _LocalDrivingLicenseApplication.LicenseClassesInfo.ClassName;
            lblNameResult.Text = _LocalDrivingLicenseApplication.PersonFullName;
            lblTrialResult.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();
            lblDateResult.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFeesResult.Text = _TestAppointment.PaidFees.ToString();
            lblTestIDResult.Text = (_TestAppointment.TestID == -1) ? "Not taken yet" : _TestAppointment.TestID.ToString();
        }
    }
}