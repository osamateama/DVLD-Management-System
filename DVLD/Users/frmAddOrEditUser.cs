using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddOrEditUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _UserID;
        private clsUser _User;

        public frmAddOrEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddOrEditUser(int UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _UserID = UserID;

        }
        private void frmAddOrEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefultValues();
            if (_Mode == enMode.Update) _LoadData();
        }
        private void _ResetDefultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblUser.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
                tagPageLoginInfo.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFoucs();
            }
            else
            {
                lblUser.Text = "Update User";
                this.Text = "Update User";
                btnsaveUser.Text = "Update";
                tagPageLoginInfo.Enabled = true;
                btnsaveUser.Enabled = true;
            }
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            txtConfirmUserPassword.Text = "";
            cbIsActive.Checked = true;

        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("This User was not found. The form will now close.");
                this.Close();
                return;
            }

            txtUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtUserPassword.Text = _User.Password;
            txtConfirmUserPassword.Text = _User.Password;
            if (_User.IsActive)
                cbIsActive.Checked = true;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
        }
        private void btncloseUser_Click(object sender, EventArgs e) => this.Close();
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                tagPageLoginInfo.Enabled = true;
                btnsaveUser.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tagPageLoginInfo"];
                return;
            }

            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if (clsUser.IsUserExistUsePersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show(
                        "The selected person already has an associated user account.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    ctrlPersonCardWithFilter1.FilterFoucs();
                }
                else
                {
                    tagPageLoginInfo.Enabled = true;
                    btnsaveUser.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tagPageLoginInfo"];
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a valid person before continuing to the login information.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ctrlPersonCardWithFilter1.FilterFoucs();

            }
        }
        private void btnsaveUser_Click(object sender, EventArgs e)
        {

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtUserPassword.Text;
            _User.IsActive = cbIsActive.Checked;

            if (_User.Save())
            {
                 MessageBox.Show("User information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                lblUser.Text = "Update User";
                btnsaveUser.Text = "Update";
                this.Text = "Update";
            }
            else
            {
                MessageBox.Show("Failed to save user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserID_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtUserID, ""); // مسح أي خطأ سابق

            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                errorProvider1.SetError(txtUserID, "User ID is required.");
                e.Cancel = true;
                return;
            }
            if (!int.TryParse(txtUserID.Text, out int userID))
            {
                errorProvider1.SetError(txtUserID, "User ID must be a valid number.");
                e.Cancel = true;
                return;
            }
            if (_Mode == enMode.AddNew && clsUser.IsExist(userID))
            {
                errorProvider1.SetError(txtUserID, "This User ID already exists.");
                e.Cancel = true;
            }
        }
        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // منع الإدخال
            }

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtUserName, "");

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "User Name is required.");
                e.Cancel = true;
            }
        }

        private void txtUserPassword_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtUserPassword, "");

            if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                errorProvider1.SetError(txtUserPassword, "Password is required.");
                e.Cancel = true;
            }
        }

        private void txtConfirmUserPassword_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtConfirmUserPassword, "");

            if (string.IsNullOrWhiteSpace(txtConfirmUserPassword.Text))
            {
                errorProvider1.SetError(txtConfirmUserPassword, "Confirm Password is required.");
                e.Cancel = true;
                return;
            }

            if (txtConfirmUserPassword.Text != txtUserPassword.Text)
            {
                errorProvider1.SetError(txtConfirmUserPassword, "Passwords do not match.");
                e.Cancel = true;
            }
        }
    }
}
