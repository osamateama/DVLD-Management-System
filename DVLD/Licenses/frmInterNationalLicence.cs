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
    public partial class frmInterNationalLicence : Form
    {
        private int _InternationalLicenseID = -1;
        public frmInterNationalLicence()
        {
            InitializeComponent();
        }
        private void ctrlDriverLicenseInfoWithFiltter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            lblLocalLicenseID.Text = SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1) return;

            if (ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.LicenseClassID != 3)
            {
                MessageBox.Show("Selected License Should be Class 3, Select Another Ane.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternaionalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llShowLicensesInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                btnIssue.Enabled = false;
                return;
            }

            btnIssue.Enabled = true;


        }

        private void frmInterNationalLicence_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = lblAppDate.Text;
            lblEpDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLicenseHistory frm = new frmLicenseHistory(ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseinfo frm = new frmInternationalLicenseinfo(_InternationalLicenseID);
            frm.ShowDialog();
        }
      

        private void btnClose_Click(object sender, EventArgs e)=> this.Close();

        private void btnIssue_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            
            clsInternationalLicense InternationalLicense = new clsInternationalLicense();

            InternationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;


            InternationalLicense.DriverID = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);

            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblILAppId.Text = InternationalLicense.ApplicationID.ToString();
            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            lblILicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssue.Enabled = false;
            ctrlDriverLicenseInfoWithFiltter1.FilterEnabled = false;
            llShowLicensesInfo.Enabled = true;


        }
    }
}
