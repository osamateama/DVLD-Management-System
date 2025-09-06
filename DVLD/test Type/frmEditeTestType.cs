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
    public partial class frmEditeTestType : Form
    {
        private clsTestType.enTestType _TestTypesID =  clsTestType.enTestType.VisionTest;
        private clsTestType _TestTypes;
        public frmEditeTestType(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTypesID = TestTypeID;
        }
        private void frmEditeTestType_Load(object sender, EventArgs e) => _LoadData();
        private void _LoadData()
        {
            _TestTypes = clsTestType.Find(_TestTypesID);
            if(_TestTypes != null)
            {
                txtTitle.Text = _TestTypes.TestTypeTitle;
                txtFees.Text = _TestTypes.TestTypeFees.ToString();
                txtDescription.Text = _TestTypes.TestTypeDescription;
                lblID.Text = ((int)_TestTypes.TestTypeID).ToString();
            }
            else
            {
                MessageBox.Show($"Test Type Id Not Found {_TestTypesID.ToString()}");
                this.Close();
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Some Field Are Not Valid ");
                return;
            }
            _TestTypes.TestTypeTitle = txtTitle.Text.Trim();
            _TestTypes.TestTypeDescription = txtDescription.Text.Trim();
            if (decimal.TryParse(txtFees.Text, out decimal fees))
                _TestTypes.TestTypeFees = fees;
            else
                MessageBox.Show("please Enter correct Number !!");
            if (_TestTypes.Save())
                MessageBox.Show("Test saved successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to save Data ❌", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnClose1_Click(object sender, EventArgs e)=> this.Close();
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
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Description is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, "");
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
