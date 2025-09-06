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
    public partial class frmRenewLocalDrivingLicense : Form
    {
        private int _NewLicenseId = -1;
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFiltter1.txtLicenseIDFocus();
            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = lblAppDate.Text;
            lblExpirationDate.Text = "???";
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();


        }

        private void ctrlDriverLicenseInfoWithFiltter1_OnLicenseSelected(int obj)
        {
            int LicenseID = obj;
            lblOldLicenseID.Text = LicenseID.ToString();

            llShowLicenseHistory.Enabled = (LicenseID != -1);
            if (LicenseID == -1)
                return;
            int DefualtValidityLength = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.LicenseClassIfo.DefaultValidityLength;
            lblExpirationDate.Text = DateTime.Now.AddYears(DefualtValidityLength).ToShortDateString();
            lblLicenseFees.Text = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.LicenseClassIfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToDecimal(lblAppFees.Text) + Convert.ToDecimal(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.Notes;

            if (!ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show($"Selected License Is Not Expiared, It Will Expiare\n On :{ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.ExpirationDate.ToShortDateString()}","Not Allowed!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            if (!ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License Is Not Active", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLicense NewLicense = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.RenewLicense(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            lblRLAppId.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseId = NewLicense.LicenseID;
            lblRenewLicenseID.Text = _NewLicenseId.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID= " + _NewLicenseId.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            ctrlDriverLicenseInfoWithFiltter1.FilterEnabled = false;
            llShowNewLicensesInfo.Enabled = true;
        }

        private void llShowNewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_NewLicenseId);
            frm.ShowDialog();

        }
    }
}
