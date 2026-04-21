    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Project;
using DVLD_Project.Global_Classes;

namespace DVLD_PresentationLayer
{
    public partial class MainForm : Form
    {   //_LoginForm for sign Out 
        frmLogin _LoginForm;
      
        public MainForm(frmLogin loginrfrm)
        {
            InitializeComponent();
            _LoginForm = loginrfrm;
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void mmToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }
        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Close();
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListApplicationsTypes frm = new frmListApplicationsTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();
        }

        private void LocalDrivingLicensesApplicationsToolMenuStrip_Click(object sender, EventArgs e)
        {
           
        }

        private void localLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalApplication frm = new frmAddUpdateLocalApplication();
            frm.ShowDialog();
        }
    }
}
