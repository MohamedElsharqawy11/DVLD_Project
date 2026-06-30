using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD_Project
{
    public partial class frmScheduleTest : Form
    {
        private int _LocalDrivingLicenseAppID = -1;
        private clsTestTypesB.enTestType _TestType = clsTestTypesB.enTestType.VisionTest;
        private int _TestAppointmentID = -1;
        public frmScheduleTest(int LocalDrivingLicenseAppID, clsTestTypesB.enTestType TestType, int TestAppointmentID = -1)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            _TestType = TestType;
            _TestAppointmentID = TestAppointmentID;
        }


        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestType = _TestType;
            ctrlScheduleTest1.LoadInfo(_LocalDrivingLicenseAppID,_TestAppointmentID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}