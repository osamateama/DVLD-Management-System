using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlUser : UserControl
    {
        private int _UserID = -1;
        private clsUser _User;
        public int UserID
        {
            get => _UserID; 
        }
        public ctrlUser()
        {
            InitializeComponent();
        }
        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUser.Find(UserID);
            if (_User == null)
            {
                MessageBox.Show("No User With User ID = " + UserID.ToString() + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();
        }
        private void _FillUserInfo()
        {
            ctrlPerson1.LoadPersonInfo(_User.PersonID);
            lblUserid.Text = _User.UserID.ToString();
            lblIsactive.Text = _User.IsActive == true ? "Yes" : "No";
            lblUsername.Text = _User.UserName.ToString();
        }
      
    }
}
