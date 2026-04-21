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
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { Addnew = 0, Update = 1 }
        private enMode _Mode = enMode.Addnew;
        private int _UserID = -1;
        clsUserB _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.Addnew;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
        }
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.Addnew)
            {
                lblStatus.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUserB();
                tabLoginInfo.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblStatus.Text = "Update User";
                this.Text = "Update User";
                tabLoginInfo.Enabled = true;
                btnSave.Enabled = true;

            }
            lblUserIDResult.Text = "[........]";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPass.Text = "";
            checkIsActive.Checked = true;
        }
        private void _LoadData()
        {
            _User = clsUserB.FindByUserId(_UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblUserIDResult.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPass.Text = _User.Password;
            checkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This Field Is Required");
                return;
            }
            else
                errorProvider1.SetError(txtUserName, null);

            if (_Mode == enMode.Addnew)
            {
                if (clsUserB.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "This User Name Is Already Exist");
                }
                else
                    errorProvider1.SetError(txtUserName, null);
            }
            else
            {
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUserB.IsUserExist(txtUserName.Text.Trim()))
                    {

                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "This User Name Is Already Exist");
                        return;
                    }
                    else
                        errorProvider1.SetError(txtUserName, null);
                }
            }

        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password Can't be Blank ");
            }
            else
                errorProvider1.SetError(txtPassword, null);
        }
        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPass.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPass, "Password Confirmation does not match Password");
            }
            else
                errorProvider1.SetError(txtConfirmPass, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                      "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (_Mode == enMode.Addnew && clsUserB.IsUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
            //{
            //    MessageBox.Show("This person already has a user account! Please choose another person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = checkIsActive.Checked;
            if (_User.Save())
            {
                lblUserIDResult.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                this.Text = "Update User";
                lblStatus.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _GotoLoginInfoTab() 
        {
            btnSave.Enabled = true;
            tabLoginInfo.Enabled = true;
            tabControl1.SelectedTab = tabControl1.TabPages["tabLoginInfo"];
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                _GotoLoginInfoTab();
                return;
            }
            if (ctrlPersonCardWithFilter1.PersonID != -1) 
            {
                if (clsUserB.IsUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
                else //Case Add 
                {
                    _GotoLoginInfoTab();
                }
            }
            else //Case Not selected
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
