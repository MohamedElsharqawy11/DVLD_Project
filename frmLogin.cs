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
using DVLD_PresentationLayer;
using DVLD_Project.Global_Classes;

namespace DVLD_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            clsUserB User = clsUserB.FindByUserNamePassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (User != null)
            {
                if (ChkRemember.Checked)
                {
                    Global_Classes.clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                    Global_Classes.clsGlobal.RememberUsernameAndPassword("", "");
                if (!User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Global_Classes.clsGlobal.CurrentUser = User;
                this.Hide();
                txtUserName.Text = "";
                txtPassword.Text = "";
                MainForm frm = new MainForm(this);
                frm.ShowDialog();
                if (clsGlobal.CurrentUser == null)
                {
                    this.Show();
                }
                else
                { this.Close(); }
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e) //Not Used Now
        {
            //string UserName = "", PassWord = "";
            //if (Global_Classes.clsGlobal.GetStoredCredential(ref UserName, ref PassWord))
            //{
            //    txtUserName.Text = UserName;
            //    txtPassword.Text = PassWord;
            //    ChkRemember.Checked = true;
            //}
            //else
            //    ChkRemember.Checked = false;
        }  
    }
}
