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
    public partial class frmManageDrivers : Form
    {
        private DataTable _dtDrivers;
        public frmManageDrivers()
        {
            InitializeComponent();
        }


        private void _LoadAllDrivers()
        {
            _dtDrivers = clsDriver.GetAll();
            //            
            dgvDrivers.DataSource = _dtDrivers;
            lbrecordnum.Text = dgvDrivers.Rows.Count.ToString();
            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns["DriverID"].HeaderText = "Driver ID";
                dgvDrivers.Columns["DriverID"].Width = 90;

                dgvDrivers.Columns["PersonID"].HeaderText = "Person ID";
                dgvDrivers.Columns["PersonID"].Width = 105;

                dgvDrivers.Columns["NationalNo"].HeaderText = "National No";
                dgvDrivers.Columns["NationalNo"].Width = 105;


                dgvDrivers.Columns["FullName"].HeaderText = "Full Name";
                dgvDrivers.Columns["FullName"].Width = 290;

                dgvDrivers.Columns["CreatedDate"].HeaderText = "Created Date";
                dgvDrivers.Columns["CreatedDate"].Width = 250;

                dgvDrivers.Columns["NumberOfActiveLicenses"].HeaderText = "Number Of Active Licenses";
                dgvDrivers.Columns["NumberOfActiveLicenses"].Width = 70;

            }
        }

        private void btnClose2_Click(object sender, EventArgs e)=>this.Close();

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            cbsearch1.SelectedIndex = 0;
            _LoadAllDrivers();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbsearch1.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID"; break;

                case "Person ID":
                    FilterColumn = "PersonID"; break;
                case "National No":
                    FilterColumn = "NationalNo"; break;
                case "Full Name":
                    FilterColumn = "FullName"; break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtsearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDrivers.DefaultView.RowFilter = "";
                lbrecordnum.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "PersonID" || FilterColumn == "DriverID")
            {
                if (int.TryParse(txtsearch.Text.Trim(), out int id))
                    _dtDrivers.DefaultView.RowFilter = $"[{FilterColumn}] = {id}";
                else
                    _dtDrivers.DefaultView.RowFilter = "1=0"; 
            }
            else if (FilterColumn == "FullName" || FilterColumn == "NationalNo")
            {
                _dtDrivers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtsearch.Text.Trim()}%'";
            }

            lbrecordnum.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void cbsearch1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtsearch.Visible = (cbsearch1.Text != "None" || cbsearch1.SelectedIndex != 0);
            if (txtsearch.Visible)
            {
                txtsearch.Text = "";
                txtsearch.Focus();
            }
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPerson frm = new ViewPerson((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInterNationalLicence frm = new frmInterNationalLicence();
            frm.ShowDialog();
        }
    }
}
