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
    public partial class frmListPeople : Form
    {
        private DataTable _DataAllPeople;
        private DataTable _dtPeople;
        private void _RefreshPeopleList()
        {
            _DataAllPeople = clsPersonB.GetAllPeople();
            _DataAllPeople.DefaultView.RowFilter = "";
            _dtPeople = _DataAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                      "FirstName", "SecondName", "ThirdName", "LastName",
                                                      "GendorCaption", "DateOfBirth", "CountryName",
                                                      "Phone", "Email");
            dgvPeople.DataSource = _dtPeople;
            lblRecordsNums.Text = _dtPeople.Rows.Count.ToString();
        }
        public frmListPeople()
        {
            InitializeComponent();
            _DataAllPeople = clsPersonB.GetAllPeople();
            _dtPeople = _DataAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
        }
        private void cmboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///////////////////// // txtFilterBy.Visible = (cmboFilterBy.Text != "None");
            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }
        private void btnAddPersonManage_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cmboFilterBy.SelectedIndex = 0;
            lblRecordsNums.Text = dgvPeople.Rows.Count.ToString();
            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 90;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 110;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 120;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 100;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;
            }
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonnID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form frm = new frmPersonDetails(PersonnID);
            frm.ShowDialog();
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Delete this Person With ID [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPersonB.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterClolumn = "";
            switch (cmboFilterBy.Text)
            {
                case "Person ID":
                    FilterClolumn = "PersonID";
                    break;
                case "First Name":
                    FilterClolumn = "FirstName";
                    break;
                case "Last Name":
                    FilterClolumn = "LastName";
                    break;
                case "National Number":
                    FilterClolumn = "NationalNo";
                    break;
                case "Nationality":
                    FilterClolumn = "CountryName";
                    break;
                case "Gendor":
                    FilterClolumn = "GendorCaption";
                    break;
                case "Phone":
                    FilterClolumn = "Phone";
                    break;
                case "Email":
                    FilterClolumn = "Email";
                    break;
                default:
                    FilterClolumn = "None";
                    break;
            }
            if (FilterClolumn == "None" || txtFilterBy.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = "";
                dgvPeople.DataSource = _dtPeople; // أعد الربط هنا يدوياً للتأكيد
                lblRecordsNums.Text = dgvPeople.Rows.Count.ToString();
                return;
            }
            //Handle if Numeric? Not Allowed Chars ;
            if (FilterClolumn == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1} ", FilterClolumn, txtFilterBy.Text.Trim());
            }
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", FilterClolumn, txtFilterBy.Text.Trim());

            lblRecordsNums.Text = dgvPeople.Rows.Count.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cmboFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
