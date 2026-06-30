using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Classes;
using DVLD_BusinessLayer;
using DVLD_Project.Properties;

namespace DVLD_Project
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID;
        private clsLicenseB _License;
        public int LicenseID { get { return _LicenseID; } }
        public clsLicenseB SelectedLicenseInfo { get { return _License; } }
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }
        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
                PbPerson.Image = Resources.Male_512;
            else
                PbPerson.Image = Resources.Female_512;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (!string.IsNullOrEmpty(ImagePath))
                if (File.Exists(ImagePath))
                    PbPerson.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicenseB.Find(_LicenseID);
            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }
            lblLicenseIDResult.Text = _License.LicenseID.ToString();
            lblIsActiveResult.Text= _License.IsActive ? "Yes" : "No";
            // lblIsDetainedResult.Text = _License.IsDetained ? "Yes" : "No";
            lblClassResult.Text = _License.LicenseClassIfo.ClassName;
            lblNameResult.Text = _License.DriverInfo.PersonInfo.FullName;
            lblNationalNoResult.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGenderResult.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblBDResult.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.BofDate);

            lblDriverIdResult.Text = _License.DriverID.ToString();
            lblIssueDateResult.Text = clsFormat.DateToShort(_License.IssueDate);
            lblExpireResult.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lblIssueReasonResult.Text = _License.IssueReasonText;
            lblNoteResult.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
            _LoadPersonImage();

        }
    }
}
