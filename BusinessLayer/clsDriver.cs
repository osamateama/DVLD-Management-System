using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public clsPerson PersonInfo;
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get;  }
        clsLicense license;
        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
            this.PersonInfo = clsPerson.Find(PersonID);

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            DriverID = clsDriverData.AddNewDriver(PersonID, CreatedByUserID);
            return (DriverID != -1);
        }

        private bool _Update()
        {
            return clsDriverData.UpdateDriver(DriverID, PersonID, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static clsDriver Find(int driverID)
        {
            int personID = -1, createdByUserID = -1;
            DateTime createdDate = DateTime.Now;

            if (clsDriverData.GetDriverInfoByID(driverID, ref personID, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(driverID, personID, createdByUserID, createdDate);
            }
            else
            {
                return null;
            }
        }
        public static clsDriver FindByPersonID(int personID)
        {
            int driverID = -1, createdByUserID = -1;
            DateTime createdDate = DateTime.Now;

            if (clsDriverData.GetDriverInfoByPersonID(personID, ref driverID, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(driverID, personID, createdByUserID, createdDate);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAll()
        {
            return clsDriverData.GetAllDrivers();
        }
        public static DataTable GetLicenses(int DriverID)
        {
            return clsLicense.GetDriverLicenses(DriverID);
        }

        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return clsInternationalLicense.GetDriverInternationalLicenses(DriverID);
        }


    }
}
