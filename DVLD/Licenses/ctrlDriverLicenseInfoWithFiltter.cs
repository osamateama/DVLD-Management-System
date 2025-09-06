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
    public partial class ctrlDriverLicenseInfoWithFiltter : UserControl
    {
        public event Action<int> OnLicenseSelected;
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }
        public ctrlDriverLicenseInfoWithFiltter()
        {
            InitializeComponent();
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get => _FilterEnabled;
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }


        private int _LicenseID = -1;
        public int LicenseID
        {
            get { return ctrlDriverLicenseInfo1.LicenseId; }
        }
        public clsLicense SelectedLicenseInfo
        {
            get { return ctrlDriverLicenseInfo1.License; }
        }
        public void LoadLicenseInfo(int LicenseId)
        {
            txtLicenseId.Text = LicenseId.ToString();
            ctrlDriverLicenseInfo1.LoadLicenseInfo(LicenseId);
            _LicenseID = ctrlDriverLicenseInfo1.LicenseId;
            if(OnLicenseSelected != null && FilterEnabled)
                OnLicenseSelected(_LicenseID);

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseId.Focus();
                return;

            }
            _LicenseID = int.Parse(txtLicenseId.Text);
            LoadLicenseInfo(_LicenseID);
        }
        public void txtLicenseIDFocus()
        {
            txtLicenseId.Focus();
        }

        private void txtLicenseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFilter.PerformClick();
            }
        }

        private void txtLicenseId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseId.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseId, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtLicenseId, null);
            }
        }
       
    }
}
