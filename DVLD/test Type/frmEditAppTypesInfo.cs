using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmEditAppTypesInfo : Form
    {
        private int _AppTypesID = -1;
        private clsApplicationType _AppTypes;

        public frmEditAppTypesInfo(int AppTypeID)
        {
            InitializeComponent();
            _AppTypesID = AppTypeID;
        }
        private void frmEditAppTypesInfo_Load(object sender, EventArgs e)=> _LoadData();

        private void _LoadData()
        {
            _AppTypes = clsApplicationType.Find(_AppTypesID);
            if (_AppTypes == null)
            {
                MessageBox.Show("Application Type was not found. The form will now close.");
                this.Close();
                return;
            }
            txtTitle.Text = _AppTypes.ApplicationTypeTitle;
            txtFees.Text = _AppTypes.ApplicationFees.ToString();
            lblID.Text = _AppTypes.ApplicationTypeID.ToString(); 
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Some Field Are Not Valid ");
                return;
            }
            if (_AppTypes == null)
                _AppTypes = new clsApplicationType();
            _AppTypes.ApplicationTypeTitle = txtTitle.Text.Trim();

            decimal fees;
            if (decimal.TryParse(txtFees.Text, out fees))
                _AppTypes.ApplicationFees = fees;
            else
                MessageBox.Show("please Enter correct Number !");

            if (_AppTypes.Save())
                MessageBox.Show("Data saved successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to save Data ❌", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnClose1_Click(object sender, EventArgs e) => this.Close();

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "Title is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTitle, "");
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees are required.");
            }
            else if (!clsValidatoin.ValidateNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees must be a valid number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, "");
            }
        }
    }
}
