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
using DVLD_Project.Global_Classes;

namespace DVLD_Project
{
    public partial class frmDetainLicenseApplication : Form
    {
        private int _DetainedID=-1;
        private int _SelectedLicenseID = -1;
        public frmDetainLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmDetainLicenseApplication_Load(object sender, EventArgs e)
        {
            lblDetainDAteResult.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByResult.Text = clsGlobal.CurrentUser.UserName;   
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix the validation errors first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            
            _DetainedID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txtbxFineFees.Text), clsGlobal.CurrentUser.UserID);
            
            if(_DetainedID == -1) 
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            lblDetainIDResult.Text = _DetainedID.ToString();
            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false ;
            lbllinkShowNewLicenseInfo.Enabled = true;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;
            lblLicenseIdResult.Text = _SelectedLicenseID.ToString();
            lblLinkShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);
            btnDetain.Enabled = false;
            if (_SelectedLicenseID == -1) { return; }
            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {

                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtbxFineFees.Focus();
            btnDetain.Enabled = true;
        }
        private void frmDetainLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void lbllinkShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }
        private void lblLinkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void txtbxFineFees_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtbxFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbxFineFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtbxFineFees, null);

            };


            if (!clsValidation.IsNumber(txtbxFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbxFineFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtbxFineFees, null);
            };
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
