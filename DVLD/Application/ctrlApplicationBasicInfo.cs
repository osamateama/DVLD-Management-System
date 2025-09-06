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
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private clsApplication _Application;

        private int _ApplicationID = -1;

        public int ApplicationID
        {
            get { return _ApplicationID; }
        }

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.Find(ApplicationID);
            if (_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }


        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;
            lblAppID.Text = _Application.ApplicationID.ToString();
            lblAppStatus.Text = _Application.TextStatus;
            lblAppType.Text = _Application.ApplicationTypeInfo.ApplicationTypeTitle;
            lblAppFees.Text = _Application.PaidFees.ToString();
            lblApplicant.Text = _Application.PersonInfo.FullName;
            lblAppDate.Text = _Application.ApplicationDate.ToString("dd/mm/yyyy");
            lblAppStatusDate.Text = _Application.LastStatusDate.ToString("dd/mm/yyyy");
            lblCUser.Text = _Application.CreatedByUserInfo.UserName;
        }
        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            lblAppID.Text = "[???]";
            lblAppStatus.Text = "[???]";
            lblAppType.Text = "[???]";
            lblAppFees.Text = "[$$$]";
            lblApplicant.Text = "[????]";
            lblAppDate.Text = "[??/??/????]";
            lblAppStatusDate.Text = "[??/??/????]";
            lblCUser.Text = "[????]";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewPerson frm = new ViewPerson(_Application.ApplicantPersonID);
            frm.ShowDialog();

            //Refresh
            LoadApplicationInfo(_ApplicationID);
        }

        
    }
}
