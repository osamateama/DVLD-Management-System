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
using static BusinessLayer.clsLicense;

namespace DVLD
{
    public partial class frmLicenseReplacement : Form
    {
        private int _NewLicenseID = -1;
        public frmLicenseReplacement()
        {
            InitializeComponent();
        }
        private int _GetApplicationTypeID()
        {
           

            if (rbDamagedLicense.Checked)

                return (int)clsApplication.enApplicationType.ReplacementForaDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplacementForaLostDrivingLicense;
        }
        private enIssueReason _GetIssueReason()
        {

            if (rbDamagedLicense.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }
        private void frmLicenseReplacement_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFiltter1.txtLicenseIDFocus();
            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            rbDamagedLicense.Checked = true;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Damaged License";
            this.Text = lblTitle.Text;
            lblAppFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).ApplicationFees.ToString();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Lost License";
            this.Text = lblTitle.Text;
            lblAppFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).ApplicationFees.ToString();
        }

        private void ctrlDriverLicenseInfoWithFiltter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;
            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            {
                return;
            }

            //dont allow a replacement if is Active .
            if (!ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            btnIssueReplacement.Enabled = true;
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            clsLicense NewLicense = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.Replace(_GetIssueReason(),clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblRLAppId.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;

            lblRreplacedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
            ctrlDriverLicenseInfoWithFiltter1.FilterEnabled = false;
            llShowNewLicensesInfo.Enabled = true;

        }

        private void llShowNewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
