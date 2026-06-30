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

namespace DVLD_Project.Applications.Rlease_Detained_License
{
    public partial class frmListDetainedLicenses : Form
    {
        private DataTable _dtDetainedLicenses;

        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenseApps.CurrentRow.Cells[1].Value;
            int PersonID = clsLicenseB.Find(LicenseID).DriverInfo.PersonID;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenseApps.CurrentRow.Cells[1].Value;
            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.ShowDialog();
        }
        private void showPersonHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenseApps.CurrentRow.Cells[1].Value;
            clsLicenseB License = clsLicenseB.Find(LicenseID);
            if (License != null)
            {
            }
        }
        private void releaseDetainedLicesneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedLicenseID = (int)dgvDetainedLicenseApps.CurrentRow.Cells[1].Value;
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(SelectedLicenseID);
            frm.ShowDialog();
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CMenuApps_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainedLicesneToolStripMenuItem.Enabled = !(bool)dgvDetainedLicenseApps.CurrentRow.Cells[3].Value;
        }
        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            _dtDetainedLicenses = clsDetainedLicenseB.GetAllDetainedLicenses();
            dgvDetainedLicenseApps.DataSource = _dtDetainedLicenses;
            lblRecordsNums.Text = dgvDetainedLicenseApps.Rows.Count.ToString();

            if (dgvDetainedLicenseApps.Rows.Count > 0)
            {
                dgvDetainedLicenseApps.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenseApps.Columns[0].Width = 60;

                dgvDetainedLicenseApps.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenseApps.Columns[1].Width = 60;

                dgvDetainedLicenseApps.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenseApps.Columns[2].Width = 100;

                dgvDetainedLicenseApps.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenseApps.Columns[3].Width = 80;

                dgvDetainedLicenseApps.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenseApps.Columns[4].Width = 80;

                dgvDetainedLicenseApps.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenseApps.Columns[5].Width = 100;

                dgvDetainedLicenseApps.Columns[6].HeaderText = "N.No.";
                dgvDetainedLicenseApps.Columns[6].Width = 60;

                dgvDetainedLicenseApps.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenseApps.Columns[7].Width = 250;

                dgvDetainedLicenseApps.Columns[8].HeaderText = "Rlease App.ID";
                dgvDetainedLicenseApps.Columns[8].Width = 100;
            }
        }
        private void cmboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboFilterBy.Text == "Is Released")
            {
                txtFilterBy.Visible = false;
                cmbIsReleased.Visible = true;
                cmbIsReleased.Focus();
                cmbIsReleased.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = (cmboFilterBy.Text != "None");
                cmbIsReleased.Visible = false;

                if (cmboFilterBy.Text == "None")
                {
                    txtFilterBy.Enabled = false;
                }
                else
                {
                    txtFilterBy.Enabled = true;
                }

                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cmboFilterBy.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;
                case "Is Released":
                    FilterColumn = "IsReleased";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                lblRecordsNums.Text = dgvDetainedLicenseApps.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblRecordsNums.Text = _dtDetainedLicenses.DefaultView.Count.ToString();
        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmboFilterBy.Text == "Detain ID" || cmboFilterBy.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cmbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";
            string FilterValue = cmbIsReleased.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtDetainedLicenses.DefaultView.RowFilter = "";
            else
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsNums.Text = _dtDetainedLicenses.DefaultView.Count.ToString();
        }
    }
}