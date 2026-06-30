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
    public partial class frmRenewLocalDrivingLicenseApplication : Form
    {
        private int _NewLicenseID = -1;
        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
            lblAppDAteResult.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDateResult.Text = lblAppDAteResult.Text;
            lblExpirationDateResult.Text = "???";
            lblAPPFeesResult.Text = clsApplicationTypesB.Find(
                (int)clsApplicationsB.enApplicationType.RenewDrivingLicense).AppFees.ToString();
            lblCreatedByResult.Text = clsGlobal.CurrentUser.UserName;
            lbllinkShowNewLicenseInfo.Enabled=false;
            lblLinkShowLicenseHistory.Enabled=false;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseId = obj;
            lblOldLicenseIdResult.Text = SelectedLicenseId.ToString();
            lblLinkShowLicenseHistory.Enabled = (SelectedLicenseId != -1);
            if (SelectedLicenseId == -1) { return; }

             int defaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.DefaultValidityLength;

            lblExpirationDateResult.Text = clsFormat.DateToShort(DateTime.Now.AddYears(defaultValidityLength));
            lblLicenseFeesResult.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.ClassFees.ToString();
            lblTotalFeesResult.Text = (Convert.ToInt32(lblLicenseFeesResult.Text) + Convert.ToInt32(lblAPPFeesResult.Text)).ToString();
            txtbxNotes.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + clsFormat.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate)
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                       , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }
            btnRenew.Enabled = true;
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicenseB NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.
                                                RenewLicense(txtbxNotes.Text, clsGlobal.CurrentUser.UserID);
            if (NewLicense == null)
            {

                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblRLAPPResult.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseIDResult.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRenew.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            lbllinkShowNewLicenseInfo.Enabled = true;
        }
        private void frmRenewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lbllinkShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }
        private void lblLinkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}