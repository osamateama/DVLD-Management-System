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
    public partial class frmReleaseDetainedLicense : Form
    {
        private int _SelectedLicenseID = -1;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            ctrlDriverLicenseInfoWithFiltter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrlDriverLicenseInfoWithFiltter1.Enabled = false;
        }

        private void ctrlDriverLicenseInfoWithFiltter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            lblLicenseID.Text = _SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1) return;

            if (!ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblDetainID.Text = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lblLicenseID.Text = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.LicenseID.ToString();

            lblCreatedBy.Text = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DetainedInfo.CreatedByUserInfo.UserName;
            lblDetainDate.Text = (ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DetainedInfo.DetainDate).ToShortDateString();
            lblFineFees.Text = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lblTotalFineFees.Text = (Convert.ToDecimal(lblApplicationFees.Text) + Convert.ToDecimal(lblFineFees.Text)).ToString();

            btnRelease.Enabled = true;

        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int ApplicationID = -1;
            bool IsReleased = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, ref ApplicationID); ;

            lblAppID.Text = ApplicationID.ToString();
            if (!IsReleased)
            {
                MessageBox.Show("Faild to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrlDriverLicenseInfoWithFiltter1.FilterEnabled = false;
            llShowLicensesInfo.Enabled = true;



        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        private void llShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }
        private void frmReleaseDetainedLicense_Activated(object sender, EventArgs e) => ctrlDriverLicenseInfoWithFiltter1.txtLicenseIDFocus();

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLicenseHistory frm = new frmLicenseHistory(ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

      
    }
}
