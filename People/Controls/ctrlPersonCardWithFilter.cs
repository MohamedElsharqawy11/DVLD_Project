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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        //delegete
        public event Action<int> OnSelectedPerson;
        //Function
        public virtual void PersonSelected(int personID)
        {
            Action<int> handler = OnSelectedPerson;
            if (handler != null)
            {
                handler(personID); //Raising Event 
            }
        }
        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                GrpFilter.Visible = _FilterEnabled;
            }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        private int _PersonID = -1;
        public int PersonID { get { return ctrlPersonCard1.PersonID; } }
        public clsPersonB SelectedPerson { get { return ctrlPersonCard1.SelectedPersonInfo; } }
        public void LoadPersonInfo(int personID)
        {
            cmboFindBy.Text = "Person ID";
            txtFilterdValue.Text = personID.ToString();
            _FindNow();
        }
        private void _FindNow()
        {
            switch (cmboFindBy.Text)
            {
                case "Person ID":
                    if (int.TryParse(txtFilterdValue.Text, out int result))
                        ctrlPersonCard1.LoadPersonInfo(result);
                    else
                        MessageBox.Show("Invalid Person ID Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "National Number":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterdValue.Text);
                    break;
                default:
                    break;
            }
            if (OnSelectedPerson != null && FilterEnabled)
            {
                if (ctrlPersonCard1.PersonID != -1)
                {
                    PersonSelected(ctrlPersonCard1.PersonID);
                }
            }
        }
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cmboFindBy.SelectedIndex = 0;
            txtFilterdValue.Focus();
        }
        private void cmboFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterdValue.Text = "";
            txtFilterdValue.Focus();
        }
        private void btnSearchperson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            _FindNow();
        }
        private void txtFilterdValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterdValue.Text.Trim()))
            {
                errorProvider1.SetError(txtFilterdValue, "This Field Is Requierd");
            }
            else
                errorProvider1.SetError(txtFilterdValue, null);
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.DataBack += DataBackNewPerson;
            frm.ShowDialog();
        }
        private void DataBackNewPerson(object sender, int personID)
        {
            cmboFindBy.Text = "Person ID"; ;
            txtFilterdValue.Text = personID.ToString();
            ctrlPersonCard1.LoadPersonInfo(personID);
            PersonSelected(personID);
        }
        public void FilterFocus() // No Useage
        {
            txtFilterdValue.Focus();
        }
        private void txtFilterdValue_KeyPress(object sender, KeyPressEventArgs e)   
        {
            if (e.KeyChar == (char)13)  //Perform Key Enter For Finding or Searchig
            {
                btnSearchperson.PerformClick();
            }
                //Handle Importance of Entering Nums in Person ID Search 
            if (cmboFindBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
