using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUpdateUser : Form
    {
        private int _UserID ;
        private clsUser _User;

        public frmUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void _ResetDefultValues()
        {
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtCurrentPassword.Focus();
        }
        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefultValues();
            _User = clsUser.Find(_UserID);
            if(_User == null)
            {
                MessageBox.Show($"Not Found User Id {_UserID}. ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlUser1.LoadUserInfo( _UserID );
        }
        private void btnsaveC_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show($"Some Field Are Not Valid! ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtNewPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefultValues();
            }
            else
            {
                MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtCurrentPassword, "");

            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(txtCurrentPassword, "Current password is required.");
                e.Cancel = true;
                return;
            }

            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                errorProvider1.SetError(txtCurrentPassword, "Incorrect current password.");
                e.Cancel = true;
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtNewPassword, "");

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNewPassword, "New password is required.");
                e.Cancel = true;
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtConfirmPassword, "");

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm password is required.");
                e.Cancel = true;
                return;
            }

            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match.");
                e.Cancel = true;
            }
        }
        private void btncloseC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
