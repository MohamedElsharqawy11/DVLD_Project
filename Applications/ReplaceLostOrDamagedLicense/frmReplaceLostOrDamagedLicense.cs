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
using static DVLD_BusinessLayer.clsLicenseB;

namespace DVLD_Project
{
    public partial class frmReplaceLostOrDamagedLicense : Form
    {
        private int _NewLicenseID = -1;
        public frmReplaceLostOrDamagedLicense()
        {
            InitializeComponent();
        }
        private int _GetAppTypeID() 
        {
            if (rdbtnDamaged.Checked)
                return (int)clsApplicationsB.enApplicationType.ReplaceDamagedDrivingLicense;
            
            else 
                return (int)clsApplicationsB.enApplicationType.ReplaceLostDrivingLicense;
        }
        private enIssueReason _GetIssueReason() 
        {
            if (rdbtnDamaged.Checked) { return enIssueReason.DamagedReplacement; }
            else 
                return enIssueReason.LostReplacement;
        }
        private void frmReplaceLostOrDamagedLicense_Load(object sender, EventArgs e)
        {
            lblAppDAteResult.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByResult.Text = clsGlobal.CurrentUser.UserName;
            rdbtnDamaged.Checked = true;

        }
        private void rdbtnDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lblFormStatus.Text = "Replacement for Damaged License";
            this.Text = lblFormStatus.Text;
            lblAPPFeesResult.Text = clsApplicationTypesB.Find(_GetAppTypeID()).AppFees.ToString();
        }
        private void rdbtnLost_CheckedChanged(object sender, EventArgs e)
        {
            lblFormStatus.Text = "Replacement for Lost License";
            this.Text = lblFormStatus.Text;
            lblAPPFeesResult.Text = clsApplicationTypesB.Find(_GetAppTypeID()).AppFees.ToString();
        }
        private void lbllinkShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }
        private void frmReplaceLostOrDamagedLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedID = obj;
            lblOldLicenseIdResult.Text = SelectedID.ToString();
            lblLinkShowLicenseHistory.Enabled = (SelectedID != -1);
            if (SelectedID == -1) { return; }
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                       , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            btnIssue.Enabled = true;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            clsLicenseB NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo
                .Replace(_GetIssueReason(), clsGlobal.CurrentUser.UserID);
                
            if(NewLicense == null) 
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblRLAPPResult.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblReplacedLicenseIDResult.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnIssue.Enabled = false;
            grbboxReason.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false; 
            lbllinkShowNewLicenseInfo.Enabled = true;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        } 
        private void lblLinkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


    }
}
