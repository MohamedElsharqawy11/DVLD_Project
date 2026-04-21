using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmLocalDrivingLicenseAppInfo : Form
    {
        private int _ApplicationID = -1;
        public frmLocalDrivingLicenseAppInfo(int applicationID)
        {
            InitializeComponent();
            applicationID = _ApplicationID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseAppInfo_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByAppID(this._ApplicationID);
        }
    }
}
