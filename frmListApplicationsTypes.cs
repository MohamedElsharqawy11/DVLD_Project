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
    public partial class frmListApplicationsTypes : Form
    {
        private DataTable _dtApplications;
        public frmListApplicationsTypes()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmListApplicationsTypes_Load(object sender, EventArgs e)
        {
            _dtApplications = clsApplicationTypesB.GetAllApps();
            dgvAppsTypes.DataSource = _dtApplications;
            lblRecordsApppsNums.Text = dgvAppsTypes.Rows.Count.ToString();
            if (dgvAppsTypes.Rows.Count > 0)
            {
                dgvAppsTypes.Columns[0].HeaderText = "ID";
                dgvAppsTypes.Columns[0].Width = 110;

                dgvAppsTypes.Columns[1].HeaderText = "Title";
                dgvAppsTypes.Columns[1].Width = 300;

                dgvAppsTypes.Columns[2].HeaderText = "Fees";
                dgvAppsTypes.Columns[2].Width = 100;
            }

        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType((int)dgvAppsTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListApplicationsTypes_Load(null, null);
        }
    }
}