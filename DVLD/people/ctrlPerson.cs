using BusinessLayer;
using DVLD.Properties;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPerson : UserControl
    {
        private int _PersonID = -1;
        private clsPerson _Person;

        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        public ctrlPerson()
        {
            InitializeComponent();
        }
        
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if(_Person ==  null)
            {
                MessageBox.Show("No Person With Person ID = " + PersonID.ToString() + " ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                MessageBox.Show("No Person With National Number = " + NationalNo + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        private void _LoadImage()
        {
            if(_Person.Gender == 0)
                pbPersonPhote.Image = Resources.male;
            else
                pbPersonPhote.Image = Resources.female_student;
            string ImagePath = _Person.ImagePath;


            if(_Person.ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonPhote.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could Not Found This Image " + ImagePath + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _FillPersonInfo()
        {
            lleditpersoninfo.Enabled = true;
            _PersonID = _Person.ID;
            lblID.Text = _PersonID.ToString();
            lblNationNumber.Text= _Person.NationalNo.ToString();
            lbl_Address.Text = _Person.Address;
            lblGeder.Text = _Person.Gender == 0 ? "Male" : "Female";
            lbl_Email.Text = _Person.Email;
            lbl_Phone.Text = _Person.Phone;
            lbl_Country.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lblfullName.Text = _Person.FullName;
            lbl_DateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();

            _LoadImage();
        }

        private void lleditpersoninfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(_PersonID);
            frm.ShowDialog();

            //refresh
            LoadPersonInfo(_PersonID);
        }

        
    }
}
