using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Project
{
    public partial class frmListLocalDrivingLicensesApps : Form
    {
        private DataTable _dtAllLocalLicenseApps;

        public frmListLocalDrivingLicensesApps()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddPersonManage_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalApplication frm = new frmAddUpdateLocalApplication();
            frm.ShowDialog();
        }
        private void frmListLocalDrivingLicensesApps_Load(object sender, EventArgs e)
        {
            _dtAllLocalLicenseApps = clsLocalDrivingLicenseApplicationsB.GetAllLocalDrivingLicenseApplications();
            dgvLocalLicenseApps.DataSource = _dtAllLocalLicenseApps;
            lblRecordsNums.Text = _dtAllLocalLicenseApps.Rows.Count.ToString();
            if (_dtAllLocalLicenseApps.Rows.Count > 0)
            {
                dgvLocalLicenseApps.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalLicenseApps.Columns[0].Width = 120;

                dgvLocalLicenseApps.Columns[1].HeaderText = "Driving Class";
                dgvLocalLicenseApps.Columns[1].Width = 300;

                dgvLocalLicenseApps.Columns[2].HeaderText = "National No.";
                dgvLocalLicenseApps.Columns[2].Width = 150;

                dgvLocalLicenseApps.Columns[3].HeaderText = "Full Name";
                dgvLocalLicenseApps.Columns[3].Width = 350;

                dgvLocalLicenseApps.Columns[4].HeaderText = "Application Date";
                dgvLocalLicenseApps.Columns[4].Width = 170;

                dgvLocalLicenseApps.Columns[5].HeaderText = "Passed Tests";
                dgvLocalLicenseApps.Columns[5].Width = 150;
            }
            cmboFilterBy.SelectedIndex = 0;
        }
        private void cmboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cmboFilterBy.Text != "None");
            if (txtFilterBy.Text != "None")
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
            _dtAllLocalLicenseApps.DefaultView.RowFilter = "";
            lblRecordsNums.Text = _dtAllLocalLicenseApps.Rows.Count.ToString();
        }
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string Filter = "";
            switch (cmboFilterBy.Text)
            {
                case "L.D.L AppID":
                    Filter = "LocalDrivingLicenseApplicationID";
                    break;
                case "National Number":
                    Filter = "NationalNo";
                    break;
                case "Full Name":
                    Filter = "FullName";
                    break;

                case "Status":
                    Filter = "Status";
                    break;
                default:
                    Filter = "";
                    break;
            }
            if (Filter == "None" || txtFilterBy.Text == "")
            {
                _dtAllLocalLicenseApps.DefaultView.RowFilter = "";
                lblRecordsNums.Text = _dtAllLocalLicenseApps.Rows.Count.ToString();
                return;
            }
            if (Filter == "LocalDrivingLicenseApplicationID")
            { 
                if (!int.TryParse(txtFilterBy.Text.Trim(), out int result))
                {
                    // لو كتب حروف، امنع الفلتر خالص عشان ميضربش
                    _dtAllLocalLicenseApps.DefaultView.RowFilter = "";
                    return;
                }
                _dtAllLocalLicenseApps.DefaultView.RowFilter = string.Format("[{0}] = {1}", Filter, txtFilterBy.Text.Trim());
            }
            else
                _dtAllLocalLicenseApps.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", Filter, txtFilterBy.Text.Trim());

            lblRecordsNums.Text = _dtAllLocalLicenseApps.Rows.Count.ToString();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenseApps.Rows.Count == 0 || dgvLocalLicenseApps.CurrentRow == null) return;
            frmLocalDrivingLicenseAppInfo frm = new frmLocalDrivingLicenseAppInfo((int)dgvLocalLicenseApps.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        
            frmListLocalDrivingLicensesApps_Load(null, null);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenseApps.Rows.Count == 0 || dgvLocalLicenseApps.CurrentRow == null) return;
            frmAddUpdateLocalApplication frm = new frmAddUpdateLocalApplication((int)dgvLocalLicenseApps.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListLocalDrivingLicensesApps_Load(null, null);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenseApps.Rows.Count == 0 || dgvLocalLicenseApps.CurrentRow == null) return;
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            clsLocalDrivingLicenseApplicationsB localApp =
                    clsLocalDrivingLicenseApplicationsB.FindByLocalDrivingAppLicense((int)dgvLocalLicenseApps.CurrentRow.Cells[0].Value);
            if (localApp != null)
            {
                if (localApp.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicensesApps_Load(null, null);
                }
            else
                MessageBox.Show("Couldn't delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenseApps.Rows.Count == 0 || dgvLocalLicenseApps.CurrentRow == null) return;
            if (MessageBox.Show("Are you sure do want to Cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            clsLocalDrivingLicenseApplicationsB localApp =
                    clsLocalDrivingLicenseApplicationsB.FindByLocalDrivingAppLicense((int)dgvLocalLicenseApps.CurrentRow.Cells[0].Value);
            if (localApp != null)
            {
                if (localApp.Cancel())
                {
                    MessageBox.Show("Application Canceled Successfully.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicensesApps_Load(null, null);
                }
                else
                    MessageBox.Show("Couldn't Cancel applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmboFilterBy.Text == "L.D.L AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        ////stop (list Local DL Apps min 11:30 ;
    }
}