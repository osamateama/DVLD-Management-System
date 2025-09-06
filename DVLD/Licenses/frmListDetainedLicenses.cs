using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD
{
    public partial class frmListDetainedLicenses : Form
    {

        private DataTable _dtListDetainedLicenses;
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }
        private void _LoadAllDetainedLicenses()
        {
            _dtListDetainedLicenses = clsDetainedLicense.GetAll();
            //
            cbsearch1.SelectedIndex = 0;
            dgvListDetainedLicenses.DataSource = _dtListDetainedLicenses;
            double sumFinePaid = Convert.ToDouble(_dtListDetainedLicenses.Compute("SUM(FineFees)", "IsReleased=1"));
            lbltotalfinespaid.Text = sumFinePaid.ToString("C", new CultureInfo("en-US"));
            lbrecordnum.Text = dgvListDetainedLicenses.Rows.Count.ToString();
            if (dgvListDetainedLicenses.Rows.Count > 0)
            {
                dgvListDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvListDetainedLicenses.Columns[0].Width = 80;

                dgvListDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvListDetainedLicenses.Columns[1].Width = 80;

                dgvListDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvListDetainedLicenses.Columns[2].Width = 160;

                dgvListDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvListDetainedLicenses.Columns[3].Width = 100;

                dgvListDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvListDetainedLicenses.Columns[4].Width = 100;

                dgvListDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvListDetainedLicenses.Columns[5].Width = 160;

                dgvListDetainedLicenses.Columns[6].HeaderText = "Rlease App.ID";
                dgvListDetainedLicenses.Columns[6].Width = 80;

                dgvListDetainedLicenses.Columns[7].HeaderText = "N.No.";
                dgvListDetainedLicenses.Columns[7].Width = 80;

                dgvListDetainedLicenses.Columns[8].HeaderText = "Full Name";
                dgvListDetainedLicenses.Columns[8].Width = 300;

            }
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            _LoadAllDetainedLicenses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetainedLicense frmDetainedLicense = new frmDetainedLicense();
            frmDetainedLicense.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbsearch1.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;
                case "Is Released":
                    {
                        FilterColumn = "IsReleased";
                        break;
                    };

                case "National No":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtsearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtListDetainedLicenses.DefaultView.RowFilter = "";
                lbrecordnum.Text = dgvListDetainedLicenses.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                //in this case we deal with numbers not string.
                _dtListDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtsearch.Text.Trim());
            else
                _dtListDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtsearch.Text.Trim());

            lbrecordnum.Text = dgvListDetainedLicenses.Rows.Count.ToString();

        }

        private void cbsearch1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbsearch1.Text == "Is Released")
            {
                txtsearch.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.Focus();
                cbIsReleased.SelectedIndex = 0;
            }

            else

            {

                txtsearch.Visible = (cbsearch1.Text != "None");
                cbIsReleased.Visible = false;

                if (cbsearch1.Text == "None")
                {
                    txtsearch.Enabled = false;

                }
                else
                    txtsearch.Enabled = true;

                txtsearch.Text = "";
                txtsearch.Focus();
            }
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";
            string FilterValue = cbIsReleased.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtListDetainedLicenses.DefaultView.RowFilter = "";
            else
                _dtListDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lbrecordnum.Text = dgvListDetainedLicenses.Rows.Count.ToString();
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbsearch1.Text == "Detain ID" || cbsearch1.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPerson frm = new ViewPerson((string)dgvListDetainedLicenses.CurrentRow.Cells[7].Value);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value;
            clsLicense license = clsLicense.Find(licenseID);
          
            frmLicenseHistory frm = new frmLicenseHistory(license.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
