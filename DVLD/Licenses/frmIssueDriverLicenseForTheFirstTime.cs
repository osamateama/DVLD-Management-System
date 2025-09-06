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
    public partial class frmIssueDriverLicenseForTheFirstTime : Form
    {
        private int _LocalDrivingLicenseAppID;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;
        public frmIssueDriverLicenseForTheFirstTime(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }
        private void btnClose_Click(object sender, EventArgs e)=>this.Close();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseID = _localDrivingLicenseApplication.IssueLicenseForTheFirtTime(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

            if (LicenseID  != -1)
            {
                MessageBox.Show($"License Issued Successfuly With Id = {LicenseID} . ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show($"License Not Issued. ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIssueDriverLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseAppID);
            if(_localDrivingLicenseApplication == null)
            {
                MessageBox.Show($"No Application With Id = {_LocalDrivingLicenseAppID} .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (!_localDrivingLicenseApplication.PassedAllTests())
            {
                MessageBox.Show("Person Should Pass All Tests", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            int LicenseID = _localDrivingLicenseApplication.GetActiveLicenseID();
            if (LicenseID != -1)
            {
                MessageBox.Show($"Person Alredy Has License With Id = {LicenseID} .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseAppID);
        }

    }
}
