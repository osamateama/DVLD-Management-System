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
    public partial class frmMain : Form
    {
        Form1 _frmLogin;
        public frmMain(Form1 frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople frm = new ManagePeople();
            frm.ShowDialog();
        }
        private void peopleToolStripMenuItem_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void applicationToolStripMenuItem_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void driversToolStripMenuItem_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void usersToolStripMenuItem_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void accountSettingsToolStripMenuItem_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers();
            frm.ShowDialog();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUser frm = new frmUpdateUser(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void singToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }
        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDivingLicenseApplications frm = new frmLocalDivingLicenseApplications();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApp frm = new NewLocalDrivingLicenseApp();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDivingLicenseApplications frm = new frmLocalDivingLicenseApplications();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense frm = new frmRenewLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamedgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseReplacement frm = new frmLicenseReplacement();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();
            frm.ShowDialog();
        }

        private void detainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainedLicense frm = new frmDetainedLicense();
            frm.ShowDialog();
        }

        private void mangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInterNationalLicence frm = new frmInterNationalLicence();
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicense frm = new frmListInternationalLicense();
            frm.ShowDialog();
        }

        private void PanalMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
