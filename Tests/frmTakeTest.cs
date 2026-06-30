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
using DVLD_Project.Global_Classes;

namespace DVLD_Project
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentID = -1;
        private clsTestTypesB.enTestType _TestType = clsTestTypesB.enTestType.VisionTest;
        private int TestID = -1;
        private clsTestB _Test;

        public frmTakeTest(int AppointmentID, clsTestTypesB.enTestType TestType)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestType = TestType;
        }
        

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.LoadInfo(_AppointmentID);
            if (ctrlScheduledTest1.TestAppointmentID == -1) 
                btnSave.Enabled = false;
            else 
                btnSave.Enabled = true; 

            int _TestID = ctrlScheduledTest1.TestID;

            if (_TestID != -1)
            {
                _Test = clsTestB.Find(_TestID);
                if (_Test.TestResult)
                    rdbPass.Checked = true;
                else
                    rdbFail.Checked = true;

                txtNotes.Text = _Test.Notes;
                lblUserMessage.Visible = true;
                rdbFail.Enabled = false;
                rdbPass.Enabled = false;
                btnSave.Enabled = false;
            }
            else
                _Test = new clsTestB();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                      "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rdbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_Test.Save()) 
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
