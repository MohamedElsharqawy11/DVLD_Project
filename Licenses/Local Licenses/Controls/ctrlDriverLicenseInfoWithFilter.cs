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
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;
        protected virtual void LicanseSelected(int licenseId)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(licenseId);
            }
        }
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                grpFilter.Enabled = _FilterEnabled;
            }
        }
        private int _LicenseId = -1;
        public int LicenseId
        {
            get { return ctrlDriverLicenseInfo1.LicenseID; }

        }
        public clsLicenseB SelectedLicenseInfo
        {
            get
            {
                return ctrlDriverLicenseInfo1.SelectedLicenseInfo;
            }
        }
        public void LoadLicenseInfo(int LicenseId)
        {
            txtFilterdValue.Text = LicenseId.ToString();
            ctrlDriverLicenseInfo1.LoadInfo(LicenseId);
            _LicenseId = ctrlDriverLicenseInfo1.LicenseID;
            if (OnLicenseSelected != null && FilterEnabled)
            {
                OnLicenseSelected(_LicenseId);
            }
        }
        private void txtFilterdValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                btnSearchLicense.PerformClick();
            }
        }
        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilterdValue.Focus();
                return;
            }
            if (int.TryParse(txtFilterdValue.Text, out int parsedid))
            {
                _LicenseId = parsedid;
                LoadLicenseInfo(_LicenseId);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric License ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void txtLicenseIDFocus() 
        {
            txtFilterdValue.Focus();
        }
        private void txtFilterdValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterdValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterdValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterdValue, null);
            }
        }
    }
}