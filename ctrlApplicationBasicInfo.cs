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

namespace DVLD_Project
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private clsApplicationsB _Application;
        private int _ApplicationID = -1;
        public int ApplicationID { get { return _ApplicationID; } }
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }
        public void LoadApplicationInfo(int ApplicationInfoID)
        {
            _Application = clsApplicationsB.FindBaseApplication(ApplicationInfoID);
            if (_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }
        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;
            lblIDResult.Text = "[......]";
            lblStatusResult.Text = "[......]";
            lblTypeResult.Text = "[......]";
            lblAPPFeesResult.Text = "[......]";
            lblApplicantResult.Text = "[......]";
            lblAppDAteResult.Text = "[......]";
            lblStatusDateResult.Text = "[......]";
            lblCreatedByResult.Text = "[......]";
        }
        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;
            lblIDResult.Text = _Application.ApplicationID.ToString();
            lblStatusResult.Text = _Application.StatusText;
            lblAPPFeesResult.Text = _Application.PaidFees.ToString();
            lblTypeResult.Text = _Application.ApplicationTypeInfo.ToString();
            lblApplicantResult.Text = _Application.ApplicantFullName;
            lblStatusDateResult.Text = clsFormat.DateToShort(_Application.LastStatusDate).ToString();
            lblAppDAteResult.Text = clsFormat.DateToShort(_Application.ApplicationDate).ToString();
            lblCreatedByResult.Text = _Application.CreatedByUserInfo.UserName;
        }
        private void lbllinkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(_Application.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}