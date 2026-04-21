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
using System.Xml.Linq;
using DVLD_BusinessLayer;

namespace DVLD_Project
{
    public partial class frmListUsers : Form
    {
        private static DataTable _dtAllUsers;
        public frmListUsers()
        {
            InitializeComponent();
        }
        private void btnAddPersonManage_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUserB.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cmboFilterBy.SelectedIndex = 0;
            lblRecordsNums.Text = dgvUsers.Rows.Count.ToString();
            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 120;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 300;

                dgvUsers.Columns[3].HeaderText = "User Name";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 120;
            }
            dgvUsers.AllowUserToAddRows = false; // السطر ده هيشيل السطر الفاضي اللي بيظهر تحت خالص ويمنع الإضافة المباشرة
            dgvUsers.ReadOnly = true; // السطر ده هيمنع المستخدم إنه يكتب أو يمسح أي حاجة جوه الخلايا بالغلط
        }
        private void cmboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboFilterBy.Text.Trim() == "Is Active")
            {
                txtFilterBy.Visible = false;
                cmboIsActive.Visible = true;
                cmboIsActive.Focus();
                cmboIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = (cmboFilterBy.Text.Trim() != "None");
                cmboIsActive.Visible = false;
                txtFilterBy.Text = "";
                if (txtFilterBy.Visible)
                    txtFilterBy.Focus();
            }
        }
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = ""; //handling UI and DB 
            switch (cmboFilterBy.Text)
            {
                case "User ID":
                    filterColumn = "UserID";
                    break;
                case "User Name":
                    filterColumn = "UserName";
                    break;
                case "Person ID":
                    filterColumn = "PersonID";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }
            if (txtFilterBy.Text.Trim() == "" || cmboFilterBy.Text.Trim() == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsNums.Text = _dtAllUsers.DefaultView.Count.ToString();
                return;
            }
            if (filterColumn == "UserID" || filterColumn == "PersonID")
            {
                if (int.TryParse(txtFilterBy.Text.Trim(), out int result))
                {
                    _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, result);
                }
                else
                {
                    _dtAllUsers.DefaultView.RowFilter = "";
                }
            }
            else
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilterBy.Text.Trim());
            }
            lblRecordsNums.Text = _dtAllUsers.DefaultView.Count.ToString();
        }
        private void cmboIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtercol = "IsActive";
            string filtervalue = cmboIsActive.Text.Trim();

            switch (filtervalue)
            {
                case "All":
                    _dtAllUsers.DefaultView.RowFilter = ""; // السطر ده اللي كان ناقص
                    break;
                case "Active":
                    filtervalue = "1";
                    _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filtercol, filtervalue);
                    break;
                case "InActive":
                    filtervalue = "0";
                    _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filtercol, filtervalue);
                    break;
            }
            lblRecordsNums.Text = _dtAllUsers.DefaultView.Count.ToString();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            Form frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            Form frm = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }
        private void ChangePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            Form frm = new frmChangeUserPassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.Rows.Count == 0) return;
            if (MessageBox.Show("Are u Sure To Delete this User With ID [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUserB.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListUsers_Load(null, null);
                }
                else
                    MessageBox.Show("User is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            Form frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cmboFilterBy.Text == "Person ID" || cmboFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}