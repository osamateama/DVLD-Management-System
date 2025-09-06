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
    public partial class ctrlDriverLicense : UserControl
    {

        private int _DriverID;
        private clsDriver _Driver;
        private DataTable _dtLocalDriverHistory;
        private DataTable _dtDriverInternationalLicensesHistory;

        public ctrlDriverLicense()
        {
            InitializeComponent();
        }
        private void _LoadLocalDriverLicenseHistory()
        {
            _dtLocalDriverHistory = clsDriver.GetLicenses(_DriverID);


            dgvLocalLicensesHistory.DataSource = _dtLocalDriverHistory;
            lblRecordlocal.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 110;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 110;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 270;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 170;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 170;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 110;

            }
        }

        private void _LoadInternationalDriverLicenseHistory()
        {
            _dtDriverInternationalLicensesHistory = clsDriver.GetInternationalLicenses(_DriverID);


            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
            lblinternationalrecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

            if (dgvInternationalLicensesHistory.Rows.Count > 0)
            {
                dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicensesHistory.Columns[0].Width = 160;

                dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicensesHistory.Columns[1].Width = 130;

                dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicensesHistory.Columns[2].Width = 130;

                dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicensesHistory.Columns[3].Width = 180;

                dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicensesHistory.Columns[4].Width = 180;

                dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicensesHistory.Columns[5].Width = 120;

            }
        }



        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.Find(_DriverID);
            if( _Driver == null)
            {
                MessageBox.Show($"There is no Driver id with{_DriverID}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _LoadLocalDriverLicenseHistory();
            _LoadInternationalDriverLicenseHistory();
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = clsDriver.FindByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show($"There Is No Driver Linked With Person ID {PersonID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Driver != null) _DriverID = _Driver.DriverID;

            _LoadLocalDriverLicenseHistory();
            _LoadInternationalDriverLicenseHistory();
        }

        public void Clear()
        {
            _dtLocalDriverHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value;
            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void showInternatinalLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseinfo frm = new frmInternationalLicenseinfo((int)dgvInternationalLicensesHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
