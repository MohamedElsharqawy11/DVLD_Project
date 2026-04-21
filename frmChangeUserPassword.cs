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
    public partial class frmChangeUserPassword : Form
    {
        private int _UserID = -1;
        clsUserB _User;
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void _ResetDefualtValues()
        {
            txtCurrentPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmPass.Text = "";
            txtCurrentPass.Focus();
        }
        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            _User = clsUserB.FindByUserId(_UserID);
            if (_User == null)
            {
                MessageBox.Show("Could not Find User with id = " + _UserID,
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
                ctrlUserCard1.LoadUserInfo(_UserID);
        }
        private void txtCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPass.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPass, "This Field Required");
                return;
            }
            else
                errorProvider1.SetError(txtCurrentPass, null);
            if (_User.Password != txtCurrentPass.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPass, "This Password Doesn't Match User's Password");
                return;
            }
            else
                errorProvider1.SetError(txtCurrentPass, null);

        }
        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPass, "This Field is Required");
            }
            else
                errorProvider1.SetError(txtNewPass, null);
        }
        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPass.Text.Trim() != txtNewPass.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPass, "Password Confirmation does not match New Password");
            }
            else
                errorProvider1.SetError(txtConfirmPass, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.Password = txtNewPass.Text.Trim();
            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
                this.Close();
            }
            else
                MessageBox.Show("An Error Occured, Password did not change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
