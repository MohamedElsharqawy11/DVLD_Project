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
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplicationsB _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseID = -1;
        private int _LicenseID;
        public int LocalDrivingLicenseID
        {
            get
            {
                return _LocalDrivingLicenseID;
            }
        }
        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadApplicationInfoByLocalDrivingAppID(int LocalDrivingAppID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplicationsB.FindByLocalDrivingAppLicense(LocalDrivingAppID);
            if (_LocalDrivingLicenseApplication == null)
            {
                ResetLocalDrivingLicenseAppInfo();
                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingAppID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseID = LocalDrivingAppID;
            _FillLocalDrivingLicenseApplicationInfo();
        }
        public void LoadApplicationInfoByAppID(int ApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplicationsB.FindByApplicationID(ApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                ResetLocalDrivingLicenseAppInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _FillLocalDrivingLicenseApplicationInfo();
        }
        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            _LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseID();
            lbllinkShowLicenseInfo.Enabled = _LicenseID != -1;
            lblDLAPPResult.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicenseResult.Text = clsLicenseClassesB.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lblPassedTestsResult.Text = _LocalDrivingLicenseApplication.GetPassedTestCount().ToString() + "/3";
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplication.ApplicationID);
        }
        public void ResetLocalDrivingLicenseAppInfo()
        {
            _LocalDrivingLicenseID = -1;
            lblDLAPPResult.Text = "[......]";
            lblAppliedForLicenseResult.Text = "[......]";
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
        }
        private void lbllinkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmShowLicenseInfo frm = new frmShowLicenseInfo(_LocalDrivingLicenseApplication.GetActiveLicenseID());
            //frm.ShowDialog();
            MessageBox.Show("Wait Untill Drivers Class then ctrlLicense info","Wait",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
