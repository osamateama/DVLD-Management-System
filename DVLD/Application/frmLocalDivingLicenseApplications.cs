using BusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLocalDivingLicenseApplications : Form
    {
        clsApplication _Application;
        private DataTable _dtLocalLicenseApps;
        public frmLocalDivingLicenseApplications()
        {
            InitializeComponent();
        }
        private void frmLocalDivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadAllLocalApplications();
            _FillSearh();
        }
        private void _LoadAllLocalApplications()
        {
            _dtLocalLicenseApps = clsLocalDrivingLicenseApplication.GetAll();
            //            
            dgvLocalApp.DataSource = _dtLocalLicenseApps;
            lbrecordnum2.Text = dgvLocalApp.Rows.Count.ToString();
            if (dgvLocalApp.Rows.Count > 0)
            {
                dgvLocalApp.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "L.D.L AppID";
                dgvLocalApp.Columns["LocalDrivingLicenseApplicationID"].Width = 80;

                dgvLocalApp.Columns["ClassName"].HeaderText = "Driving Class";
                dgvLocalApp.Columns["ClassName"].Width = 350;

                dgvLocalApp.Columns["NationalNo"].HeaderText = "National No";
                dgvLocalApp.Columns["NationalNo"].Width = 110;

                dgvLocalApp.Columns["FullName"].HeaderText = "Full Name";
                dgvLocalApp.Columns["FullName"].Width = 290;

                dgvLocalApp.Columns["ApplicationDate"].HeaderText = "App Date";
                dgvLocalApp.Columns["ApplicationDate"].Width = 150;

                dgvLocalApp.Columns["PassedTestCount"].HeaderText = "Passed Tests";
                dgvLocalApp.Columns["PassedTestCount"].Width = 70;

            }
        }
        private void _FillSearh()
        {
            cbsearch.Items.Clear(); // نحذف أي عناصر موجودة

            // نضيف العناصر المطلوبة فقط
            cbsearch.Items.Add("None");
            cbsearch.Items.Add("Application ID");
            cbsearch.Items.Add("National No");
            cbsearch.Items.Add("Full Name");
            cbsearch.Items.Add("Status");

            cbsearch.SelectedIndex = 0;
            //
            cbsearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsearch.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            cbsearch.FlatStyle = FlatStyle.Flat;
        }
        private void txtsearch1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbsearch.Text)
            {
                case "Application ID":
                    FilterColumn = "LocalDrivingLicenseApplicationID"; break;
                case "National No":
                    FilterColumn = "NationalNo"; break;
                case "Full Name":
                    FilterColumn = "FullName"; break;
                case "Status":
                    FilterColumn = "Status"; break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtsearch1.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtLocalLicenseApps.DefaultView.RowFilter = "";
                lbrecordnum2.Text = dgvLocalApp.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
            {
                if (int.TryParse(txtsearch1.Text.Trim(), out int val))
                    _dtLocalLicenseApps.DefaultView.RowFilter = $"[{FilterColumn}] = {val}";
                else
                    _dtLocalLicenseApps.DefaultView.RowFilter = "1=0";
            }
            else
            {
                _dtLocalLicenseApps.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '%{txtsearch1.Text.Trim()}%'";
            }

            lbrecordnum2.Text = _dtLocalLicenseApps.DefaultView.Count.ToString();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApp frm = new NewLocalDrivingLicenseApp();
            frm.ShowDialog();
            frmLocalDivingLicenseApplications_Load(null, null);
        }
        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch1.Visible = (cbsearch.Text != "None" );
            if (txtsearch1.Visible)
            {
                txtsearch1.Text = "";
                txtsearch1.Focus();
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID = Convert.ToInt32(dgvLocalApp.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"Are you sure you want to delete Application [{AppID}]?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsLocalDrivingLicenseApplication LocalDrivingLicense = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(AppID);
                if (LocalDrivingLicense != null)
                {
                    if (LocalDrivingLicense.Delete())
                    {
                        MessageBox.Show("Application deleted successfully.");
                        frmLocalDivingLicenseApplications_Load(null, null);
                    }
                    else
                        MessageBox.Show("Failed to delete Application.");
                }
            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frm = new frmLocalDrivingLicenseApplicationInfo((int)dgvLocalApp.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmLocalDivingLicenseApplications_Load(null, null);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure To Cancel This Application.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            int LDLAppID = (int)dgvLocalApp.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicense = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LDLAppID);
            if(LocalDrivingLicense != null)
            {
                if (LocalDrivingLicense.Cancelled())
                {
                    MessageBox.Show("This Application Cancelled Successfuly .", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLocalDivingLicenseApplications_Load(null, null);
                }
                else
                    MessageBox.Show("Failed Cancele Application .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalApp.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                    clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID
                                                    (LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)dgvLocalApp.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //Enabled only if person passed all tests and Does not have license. 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            editApplicationToolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            scheduleTestToolStripMenuItem.Enabled = !LicenseExists;

            //Enable / Disable Cancel Menue Item
            //We only canel the applications with status = new.
            cancelToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            deleteApplicationToolStripMenuItem.Enabled =
                (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);



            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreeTest);

            scheduleTestToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            if (scheduleTestToolStripMenuItem.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                scheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                scheduleWrittenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }

        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApp frm = new NewLocalDrivingLicenseApp((int)dgvLocalApp.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments((int)dgvLocalApp.CurrentRow.Cells[0].Value, clsTestType.enTestType.VisionTest);
            frm.ShowDialog();
            frmLocalDivingLicenseApplications_Load(null, null);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments((int)dgvLocalApp.CurrentRow.Cells[0].Value, clsTestType.enTestType.WrittenTest);
            frm.ShowDialog();
            frmLocalDivingLicenseApplications_Load(null, null);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestAppointments frm = new frmListTestAppointments((int)dgvLocalApp.CurrentRow.Cells[0].Value, clsTestType.enTestType.StreeTest);
            frm.ShowDialog();
            frmLocalDivingLicenseApplications_Load(null, null);
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicenseForTheFirstTime frm = new frmIssueDriverLicenseForTheFirstTime((int)dgvLocalApp.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        //
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalApp.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(
               LocalDrivingLicenseApplicationID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalApp.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            frmLicenseHistory frm = new frmLicenseHistory(localDrivingLicenseApplication.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
