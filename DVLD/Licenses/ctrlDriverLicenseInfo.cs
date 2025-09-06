using BusinessLayer;
using DVLD.Properties;
using System;

using System.IO;
using System.Windows.Forms;
using static BusinessLayer.clsLicense;

namespace DVLD
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseId = -1;
        private clsLicense _License;
        public int LicenseId
        {
            get { return _LicenseId; }
        }
        public clsLicense License
        {
            get { return _License; }
        }

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int LicenseId)
        {
            _LicenseId = LicenseId;
            _License = clsLicense.Find(_LicenseId);
            if (_License == null)
            {
                MessageBox.Show($"No License With ID = {LicenseId}" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblClass.Text = _License.LicenseClassIfo.ClassName;
            lblName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblIssueReason.Text = ((enIssueReason)_License.IssueReason).ToString();
            lblNotes.Text = _License.Notes == ""? "No Notes": _License.Notes.ToString();
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverId.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
            _LoadImage();
        }
        private void _LoadImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
                pbImage.Image = Resources.male;
            else
                pbImage.Image = Resources.female_student;
            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could Not Found This Image " + ImagePath + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
