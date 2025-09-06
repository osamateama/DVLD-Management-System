using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using DVLD.Properties;
using System.ComponentModel;
using System.Drawing;

namespace DVLD
{
    public partial class frmAddNewPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 0, Update = 1 }
        public enum enGender { Male = 0, Female = 1 }

        private enMode _Mode;
        private enGender _Gender;
        private int _PersonID;
        private clsPerson _Person;
        private bool isDefaultImage = false;

        public frmAddNewPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddNewPerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }
        
        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            rbMale.Tag = 0;
            rbFemale.Tag = -1;
            _ResetDefultValues();
            if(_Mode == enMode.Update)
                _LoadData();
        }
        private void _ResetDefultValues()
        {
            _FillCountryINComboBox();
            if (_Mode == enMode.AddNew)
            {
                lbladdnew.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lbladdnew.Text = " Update Person ";
            }
            if (rbMale.Checked)
                pbimgperson.Image = Resources.male;

            else if(rbFemale.Checked)
                pbimgperson.Image = Resources.female_student;

            llremoveimg.Visible = (pbimgperson.Location != null);

            dateOfBirth.MaxDate= DateTime.Now.AddYears(-18);
            dateOfBirth.Value = dateOfBirth.MaxDate;

            dateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Egypt");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtaddress.Text = "";
            rbMale.Checked = true;
            txtNationalNo.Text = "";
            txtemail.Text = "";
            tbphone.Text = "";

        }
        private void _LoadData()
        {

            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("This person was not found. The form will now close.");
                this.Close();
                return;
            }

            Lablepersonid.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            tbphone.Text = _Person.Phone;
            txtemail.Text = _Person.Email;
            txtaddress.Text = _Person.Address;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);
            dateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            try
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
                {
                    pbimgperson.ImageLocation = _Person.ImagePath;
                    llremoveimg.Visible = (_Person.ImagePath != null || _Person.ImagePath != "");
                    isDefaultImage = false;
                }
                else
                    throw new Exception(); // يجبر تحميل صورة الجندر
            }
            catch
            {
                if (_Person.Gender == 0)
                    pbimgperson.Image = Properties.Resources.male;
                else
                    pbimgperson.Image = Properties.Resources.female_student;

                isDefaultImage = true;
            }
        }

        private void _FillCountryINComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow dr in dt.Rows)
                cbCountry.Items.Add(dr["CountryName"]);
        }

        private void WriteFile(string path, string data)
        {
            StreamWriter WriteData = new StreamWriter(path, true);
            WriteData.WriteLine(data);
            WriteData.Close();
        }

        // التحقق من صحة الإدخالات

        private void tbphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void tbSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void tbThirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        // التعامل مع الصورة

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                pbimgperson.Image = Properties.Resources.male;
                isDefaultImage = true;
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                pbimgperson.Image = Properties.Resources.female_student;
                isDefaultImage = true;
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isDefaultImage)
            {
                pbimgperson.Image = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbimgperson.ImageLocation = selectedFilePath;
                isDefaultImage = false;
                llremoveimg.Visible = true;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbimgperson.ImageLocation = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            if (rbMale.Checked)
            {
                pbimgperson.Image = Properties.Resources.male;
                isDefaultImage = true;
            }
            else if (rbFemale.Checked)
            {
                pbimgperson.Image = Properties.Resources.female_student;
                isDefaultImage = true;
            }
            else
            {
                MessageBox.Show("Please select gender first.");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (_Person == null)
                _Person = new clsPerson();
            if (!_HandelPersonImage())
                return;

            int CountryID = clsCountry.Find(cbCountry.Text).ID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Address = txtaddress.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtemail.Text.Trim();
            _Person.Phone = tbphone.Text.Trim();
            _Person.DateOfBirth = dateOfBirth.Value;
            _Person.NationalityCountryID = CountryID;

            if (pbimgperson.ImageLocation != null)
                _Person.ImagePath = pbimgperson.ImageLocation.ToString();
            else
                _Person.ImagePath = "";


            if (rbMale.Checked)
                _Person.Gender = (byte)enGender.Male;
            else
                _Person.Gender = (byte)enGender.Female;


            if (_Person.Save())
            {
                DataBack?.Invoke(this, _Person.ID);
                _PersonID = _Person.ID;
                _Mode = enMode.Update;
                if (_Mode == enMode.AddNew && !isDefaultImage && !string.IsNullOrEmpty(_Person.ImagePath))
                {
                    WriteFile("D:\\C#\\project 19\\DVLD\\Files\\imgs.txt", _Person.ImagePath);
                }
                MessageBox.Show("Person saved successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbladdnew.Text = " Update Person ";
                Lablepersonid.Text = _PersonID.ToString();

            }
            else
            {
                MessageBox.Show("Failed to save person ❌", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);

            if (string.IsNullOrWhiteSpace(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtFirstName_Validating_1(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            if(txtemail.Text.Trim() == "")
                return;
            if (!clsValidatoin.ValidateEmail(txtemail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtemail, "Invalid Email Address Format");
            }
            else
            {
                errorProvider1.SetError(txtemail, null);
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel= true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
            // make sure the national number not used befor
            if(txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel= true;
                errorProvider1.SetError(txtNationalNo, "National Number Is Used For Another Person!");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void cbCountry_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = (ComboBox)sender;

            if (temp.SelectedIndex == -1) // يعني المستخدم ما اختارش حاجة
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "Please select a country");
            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void tbphone_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            string phone = temp.Text.Trim();

            if (string.IsNullOrWhiteSpace(phone))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "Phone number is required");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[0-9]{10,15}$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "Invalid phone number");
            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void txtaddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }
        private bool _HandelPersonImage()
        {
          if(_Person.ImagePath != pbimgperson.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch(IOException)
                    {
                        //
                    }
                }
            }
          if(pbimgperson.ImageLocation != null)
            {
                string sourceImgFile = pbimgperson.ImageLocation.ToString();
                if(clsUtil.CopyImageToProjectImagesFolder(ref sourceImgFile))
                {
                    pbimgperson.ImageLocation = sourceImgFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

    }
}
