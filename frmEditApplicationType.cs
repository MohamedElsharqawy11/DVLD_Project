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
    public partial class frmEditApplicationType : Form
    {
        private int _AppID = -1;
        private clsApplicationTypesB _App;
        public frmEditApplicationType(int AppID)
        {
            InitializeComponent();
            this._AppID = AppID;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            lblIDResult.Text = _AppID.ToString();
            _App = clsApplicationTypesB.Find(_AppID);
            if (_App == null)
            {

                MessageBox.Show(" Application Type was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            txtTitle.Text = _App.AppTitle;
            txtFees.Text = _App.AppFees.ToString();

        }
        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "This Field Can't be empty");
            }
            else
                errorProvider1.SetError(txtTitle, null);

        }
        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This Field Can't be empty");
                return;
            }
            else
                errorProvider1.SetError(txtFees, null);

            if (!clsValidation.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Please enter a valid number.");
            }
            else
                errorProvider1.SetError(txtFees, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_App == null)
            { return; }

            _App.AppTitle = txtTitle.Text.Trim();
            _App.AppFees = Convert.ToSingle(txtFees.Text.Trim());

            if (_App.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
