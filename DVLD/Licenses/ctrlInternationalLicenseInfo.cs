using BusinessLayer;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using static BusinessLayer.clsLicense;

namespace DVLD
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        private int _IntLicenseId = -1;
        private clsInternationalLicense _IntLicense;

        public int IntLicenseId
        {
            get { return _IntLicenseId; }
        }
        public clsInternationalLicense IntLicense
        {
            get { return _IntLicense; }
        }


        
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int internastionalLicenseId)
        {
            _IntLicenseId = internastionalLicenseId;
            _IntLicense = clsInternationalLicense.Find(_IntLicenseId);
            if (_IntLicense == null)
            {
                MessageBox.Show($"No International License With ID = {_IntLicense}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblName.Text = _IntLicense.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _IntLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = _IntLicense.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = _IntLicense.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblIssueDate.Text = _IntLicense.IssueDate.ToShortDateString();
            lblIsActive.Text = _IntLicense.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = _IntLicense.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverId.Text = _IntLicense.DriverID.ToString();
            lblExpirationDate.Text = _IntLicense.ExpirationDate.ToShortDateString();
            lblInternationalID.Text = _IntLicense.InternationalLicenseID.ToString();
            _LoadImage();
        }
        private void _LoadImage()
        {
            if (_IntLicense.DriverInfo.PersonInfo.Gender == 0)
                pbImage.Image = Resources.male;
            else
                pbImage.Image = Resources.female_student;
            string ImagePath = _IntLicense.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could Not Found This Image " + ImagePath + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }
}
