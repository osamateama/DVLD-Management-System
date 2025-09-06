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
    public partial class NewLocalDrivingLicenseApp : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _LDLAppID;
        private int _SelectedPersonID = -1;
        private clsLocalDrivingLicenseApplication _LDLAppApplication;
        public NewLocalDrivingLicenseApp()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public NewLocalDrivingLicenseApp(int LDLAppID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LDLAppID = LDLAppID;
        }
        private void NewLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _ResetDefultValues();
            StyleComboBox(cbFillLicenseClass);
            if (_Mode == enMode.Update) _LoadData();
        }
        private void _ResetDefultValues()
        {
            _FillComboLicenceClass();
            if (_Mode == enMode.AddNew)
            {
                lblUserName.Text = clsGlobal.CurrentUser.UserName;
                this.Text = "Add New Local Driving License Application";
                lblAddOrUpdate.Text = "Add New Local Driving License Application";
                _LDLAppApplication = new clsLocalDrivingLicenseApplication();
                ctrlPersonCardWithFilter1.FilterFoucs();

                cbFillLicenseClass.SelectedIndex = 2;
                lblAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewDrivingLicense).ApplicationFees.ToString();
                lblAppDate.Text = DateTime.Now.ToString();
                tagPageApplicationInfo.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFoucs();
            }
            else
            {
                this.Text = "Update Local Driving License Application";
                lblAddOrUpdate.Text = "Update Local Driving License Application";

                tagPageApplicationInfo.Enabled = true;
                btnsaveUser.Enabled = true;
            }

        }
        private void _FillComboLicenceClass()
        {
            DataTable dt = clsLicenseClass.GetAll();
            foreach (DataRow dr in dt.Rows)
            {
                cbFillLicenseClass.Items.Add(dr["ClassName"]);
            }
        }


        private void _LoadData()
        {
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            _LDLAppApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LDLAppID);
            if (_LDLAppApplication == null)
            {
                MessageBox.Show("Application not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlPersonCardWithFilter1.LoadPersonInfo(_LDLAppApplication.ApplicantPersonID);

            lblAppID.Text = _LDLAppApplication.LocalDrivingLicenseApplicationID.ToString();
            if (_LDLAppApplication.ApplicationInfo != null)
            {
                lblAppDate.Text = _LDLAppApplication.ApplicationInfo.ApplicationDate.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Application base info not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblAppDate.Text = "N/A";
            }
            lblAppFees.Text = _LDLAppApplication.ApplicationInfo.PaidFees.ToString();
            cbFillLicenseClass.SelectedIndex = cbFillLicenseClass.FindString(clsLicenseClass.Find(_LDLAppApplication.LicenseClassID).ClassName);
            lblUserName.Text = clsUser.Find(_LDLAppApplication.CreatedByUserID).UserName;
        }

        private void btncloseUser_Click(object sender, EventArgs e) => this.Close();

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                tagPageApplicationInfo.Enabled = true;
                btnsaveUser.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tagPageApplicationInfo"];
                return;
            }
            else
            {
                tagPageApplicationInfo.Enabled = true;
                btnsaveUser.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tagPageApplicationInfo"];
            }

        }
        private void btnsaveUser_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLicenseClass.FindString(cbFillLicenseClass.Text).LicenseClassID;

            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID,clsApplication.enApplicationType.NewDrivingLicense,LicenseID);
            if(ActiveApplicationID != -1)
            {
                MessageBox.Show("Select Another License Class,\n The Selected Person Alredy Have An Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LDLAppApplication.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonID;
            _LDLAppApplication.ApplicationDate = DateTime.Now;
            _LDLAppApplication.ApplicationTypeID = 1;
            _LDLAppApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LDLAppApplication.LastStatusDate = DateTime.Now;
            _LDLAppApplication.LicenseClassID = LicenseID;
            _LDLAppApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (!decimal.TryParse(lblAppFees.Text, out decimal fees))
            {
                MessageBox.Show("Invalid Fees Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LDLAppApplication.PaidFees = fees;

            if (_LDLAppApplication.Save())
            {
                lblAppID.Text = _LDLAppApplication.ApplicationID.ToString();
                _Mode = enMode.Update;
                this.Text = "Update Local Driving License Application";
                lblAddOrUpdate.Text = "Update Local Driving License Application";
                MessageBox.Show("Information Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To Save Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StyleComboBox(ComboBox comboBox)
        {
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            comboBox.ForeColor = Color.FromArgb(40, 40, 40);
            comboBox.BackColor = Color.White;                 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Width = 350;
            comboBox.Height = 35;
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)=> _SelectedPersonID = obj;


        private void NewLocalDrivingLicenseApp_Activated(object sender, EventArgs e)=> ctrlPersonCardWithFilter1.FilterFoucs();

    }
}
