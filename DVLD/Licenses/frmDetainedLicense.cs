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
    public partial class frmDetainedLicense : Form
    {
        private int _NewLicenseId = -1;
        private int _DetainID = -1;
        public frmDetainedLicense()
        {
            InitializeComponent();
        }

        private void frmDetainedLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFiltter1.txtLicenseIDFocus();
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }
        private void ctrlDriverLicenseInfoWithFiltter1_OnLicenseSelected(int obj)
        {

            _NewLicenseId = obj;
            lblLicenseID.Text = _NewLicenseId.ToString();
            llShowLicenseHistory.Enabled = (_NewLicenseId != -1);

            if (_NewLicenseId == -1)
                return;

            if (!ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License Is Not Active", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                txtFees.Enabled = false;
                return;
            }
            if (clsDetainedLicense.IsLicenseDetained(_NewLicenseId))
            {
                MessageBox.Show("Selected License Is Detained ", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                txtFees.Enabled = false;
                return;
            }
            btnDetain.Enabled = true;
            txtFees.Enabled = true;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Detain the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo == null)
            {
                MessageBox.Show("Please select a license first.");
                return;
            }
            _DetainID = ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txtFees.Text), clsGlobal.CurrentUser.UserID);
            if (_DetainID == -1)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFiltter1.FilterEnabled = false;
            txtFees.Enabled = false;
            llShowLicensesInfo.Enabled = true;

        }

        private void llShowNewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_NewLicenseId);
            frm.ShowDialog();
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFees, null);

            }


            if (!clsValidatoin.ValidateNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ctrlDriverLicenseInfoWithFiltter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
