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
    public partial class ctrlDriverLicesnes : UserControl

    {
        private int _DriverID;
        private clsDriverB _Driver;
        private DataTable _LocalLincenses;
        private DataTable _InternationalLincenses;
        public ctrlDriverLicesnes()
        {
            InitializeComponent();
        }
        private void _LoadLocalLicensesInfo() 
        {
            _LocalLincenses = clsDriverB.GetLicenses(_DriverID);
           dgvLocalLicense.DataSource = _LocalLincenses;
            lblRecordsNums.Text = dgvLocalLicense.Rows.Count.ToString();
            if(dgvLocalLicense.Rows.Count > 0)
            {
                dgvLocalLicense.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicense.Columns[0].Width = 70;

                dgvLocalLicense.Columns[1].HeaderText = "App.ID";
                dgvLocalLicense.Columns[1].Width = 70;

                dgvLocalLicense.Columns[2].HeaderText = "Class Name";
                dgvLocalLicense.Columns[2].Width = 200;

                dgvLocalLicense.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicense.Columns[3].Width = 120;

                dgvLocalLicense.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicense.Columns[4].Width = 120;

                dgvLocalLicense.Columns[5].HeaderText = "Is Active";
                dgvLocalLicense.Columns[5].Width = 70;
            }

        }
        //private void _LoadInternationalLicensesInfo() 
        //{
        //_InternationalLincenses = clsDriverB.
        //}

    }
}