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
    public partial class ctrlUserCard : UserControl
    {
        private clsUserB _User;
        private int _UserID = -1;
        public int UserID { get { return _UserID; } }
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUserB.FindByUserId(UserID);
            if (_User == null)
            {
                _ResetUserInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();
        }
        private void _ResetUserInfo()
        {
            _UserID = -1;
            ctrlPersonCard1.ResetPersonInfo();
            lblUsrIDResult.Text = "[........]";
            lblUserNameResult.Text = "[........]";
            lblIsActiveResult.Text = "[........]";
        }
        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUsrIDResult.Text = _User.UserID.ToString();
            lblUserNameResult.Text = _User.UserName.ToString();
            lblIsActiveResult.Text = _User.IsActive ? "Yes" : "No";
        }
    }
}
