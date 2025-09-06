using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {SecondName} {ThirdName} {LastName}";
            }
        }

        public DateTime DateOfBirth { set; get; }
        public byte Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string ImagePath { set; get; }
        public int NationalityCountryID { set; get; }

        public clsCountry CountryInfo;


        public clsPerson()
        {
            this.ID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            this.NationalityCountryID = -1;
            Mode = enMode.AddNew;
        }

        private clsPerson(int ID, string NationalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.ID = ID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountry.Find(NationalityCountryID); 
            Mode = enMode.Update;
        }

        public static clsPerson Find(int ID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            byte Gender = 0;
            int NationalityCountryID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPersonData.GetPersonInfoByID(ID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                    DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson Find(string NationalNo)
        {
            int ID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            byte Gender = 0;
            int NationalityCountryID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref ID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                    DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewPerson()
        {
            this.ID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return (this.ID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.ID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }


        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
         public static DataTable GetPeoplePage(int pageNumber, int rowsPerPage)
         {
            return clsPersonData.GetPeoplePage(pageNumber, rowsPerPage);
         }

        public static bool IsPersonExist(int ID)
        {
            return clsPersonData.IsPersonExist(ID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }
        public static int GetPeopleCount()
        {
            return clsPersonData.GetPeopleCount();
        }

    }
}
