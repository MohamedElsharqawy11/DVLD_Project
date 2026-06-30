using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            frmListLocalDrivingLicensesApps_Load(null, null);
        }
        private void frmListLocalDrivingLicensesApps_Load(object sender, EventArgs e)
        {
            _dtAllLocalLicenseApps = clsLocalDrivingLicenseApplicationsB.GetAllLocalDrivingLicenseApplications();
            dgvLocalLicenseApps.DataSource = _dtAllLocalLicenseApps;
            lblRecordsNums.Text = _dtAllLocalLicenseApps.Rows.Count.ToString();
            if (_dtAllLocalLicenseApps.Rows.Count > 0)
            {
                dgvLocalLicenseApps.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalLicenseApps.Columns[0].Width = 100;

                dgvLocalLicenseApps.Columns[1].HeaderText = "Driving Class";
                dgvLocalLicenseApps.Columns[1].Width = 200;

                dgvLocalLicenseApps.Columns[2].HeaderText = "National No.";
                dgvLocalLicenseApps.Columns[2].Width = 100;

                dgvLocalLicenseApps.Columns[3].HeaderText = "Full Name";
                dgvLocalLicenseApps.Columns[3].Width = 250;

                dgvLocalLicenseApps.Columns[4].HeaderText = "Application Date";
                dgvLocalLicenseApps.Columns[4].Width = 120;

                dgvLocalLicenseApps.Columns[5].HeaderText = "Passed Tests";
                dgvLocalLicenseApps.Columns[5].Width = 100;
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
        private void CMenuApps_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalLicenseApps.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplicationsB localDrivingLicenseApplication =
                clsLocalDrivingLicenseApplicationsB.FindByLocalDrivingAppLicense(LocalDrivingLicenseApplicationID);
            int totalPassed = (int)dgvLocalLicenseApps.CurrentRow.Cells[5].Value;
            bool isLicenseExist = localDrivingLicenseApplication.IsLicenseIssued();

            issueDrivingLicenseToolStripMenuItem.Enabled = (totalPassed == 3 && !isLicenseExist);
            showLicenseToolStripMenuItem.Enabled = isLicenseExist;
            editToolStripMenuItem.Enabled = !isLicenseExist && (localDrivingLicenseApplication.ApplicaionStatus == clsApplicationsB.enApplicaionStatus.New);
            ScheduleTests.Enabled = !isLicenseExist;
            cancelApplicationToolStripMenuItem.Enabled = localDrivingLicenseApplication.ApplicaionStatus == clsApplicationsB.enApplicaionStatus.New;
            deleteToolStripMenuItem.Enabled = localDrivingLicenseApplication.ApplicaionStatus == clsApplicationsB.enApplicaionStatus.New;
            bool PassedVisionTest = localDrivingLicenseApplication.DoesPassTestType(clsTestTypesB.enTestType.VisionTest); ;
            bool PassedWrittenTest = localDrivingLicenseApplication.DoesPassTestType(clsTestTypesB.enTestType.WrittenTest);
            bool PassedStreetTest = localDrivingLicenseApplication.DoesPassTestType(clsTestTypesB.enTestType.StreetTest);
            ScheduleTests.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest
                && localDrivingLicenseApplication.ApplicaionStatus == clsApplicationsB.enApplicaionStatus.New);

            if (ScheduleTests.Enabled)
            {
                ScheduleVisionTest.Enabled = !PassedVisionTest;
                ScheduleWrittenTest.Enabled = PassedVisionTest && !PassedWrittenTest;
                ScheduleStreetTest.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;
            }
        }
        private void _ScheduleTest(clsTestTypesB.enTestType TestType)
        {
            int localDrivingLicenseID = (int)dgvLocalLicenseApps.CurrentRow.Cells[0].Value;
            frmListTestsAppointments frm = new frmListTestsAppointments(localDrivingLicenseID, TestType);
            frm.ShowDialog();
            frmListLocalDrivingLicensesApps_Load(null, null);
        }
        private void ScheduleVisionTest_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypesB.enTestType.VisionTest);
        }
        private void ScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypesB.enTestType.WrittenTest);
        }
        private void ScheduleStreetTest_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypesB.enTestType.StreetTest);
        }









        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseAppID = (int)dgvLocalLicenseApps.CurrentRow.Cells[0].Value;
            int licenseID = clsLocalDrivingLicenseApplicationsB.FindByLocalDrivingAppLicense(localDrivingLicenseAppID).GetActiveLicenseID();
            if (licenseID != -1)
            {
                frmLicenseInfo frm = new frmLicenseInfo(licenseID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime((int)dgvLocalLicenseApps.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicensesApps_Load(null, null);
        }
        private void showPersonHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        //last 3 Functions 
    }
}