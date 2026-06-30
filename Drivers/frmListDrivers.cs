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
    public partial class frmListDrivers : Form
    {
        private DataTable _dtAllDrivers;
        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cmboFilterBy.Text != "None");
            if (txtFilterBy.Text == "None")
            {
                txtFilterBy.Enabled = false;
            }
            else
                txtFilterBy.Enabled = true;
            txtFilterBy.Text = "";
            txtFilterBy.Focus();
        }
        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            cmboFilterBy.SelectedIndex = 0;
            _dtAllDrivers = clsDriverB.GetAllDrivers();
            dgvDrivers.DataSource = _dtAllDrivers;
            lblRecordsNums.Text = dgvDrivers.Rows.Count.ToString();
            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 70;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 70;

                dgvDrivers.Columns[2].HeaderText = "National No.";
                dgvDrivers.Columns[2].Width = 70;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 180;

                dgvDrivers.Columns[4].HeaderText = "Date";
                dgvDrivers.Columns[4].Width = 100;

                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 100;
            }

        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmboFilterBy.Text == "Driver ID" || cmboFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterFocusColumn = "";

            switch (cmboFilterBy.Text)
            {
                case "Driver ID":
                    FilterFocusColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterFocusColumn = "PersonID";
                    break;

                case "National No.":
                    FilterFocusColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterFocusColumn = "FullName";
                    break;

                default:
                    FilterFocusColumn = "None";
                    break;
            }
            if (txtFilterBy.Text.Trim() == "" || FilterFocusColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsNums.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }

            if (FilterFocusColumn != "FullName" && FilterFocusColumn != "NationalNo")
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterFocusColumn, txtFilterBy.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterFocusColumn, txtFilterBy.Text.Trim());

            lblRecordsNums.Text = dgvDrivers.Rows.Count.ToString();
        }
        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmListDrivers_Load(null, null);
        }

        private void IssueINternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.");
        }

        private void LicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.");
        }
    }
}