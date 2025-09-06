using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsDetainedLicense
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { set; get; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public clsUser ReleasedByUserInfo { set; get; }
        public int? ReleaseApplicationID { get; set; }

        public clsDetainedLicense()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = null;
            ReleasedByUserID = -1;
            ReleaseApplicationID = null;

            Mode = enMode.AddNew;
        }

        private clsDetainedLicense(int detainID, int licenseID, DateTime detainDate, decimal fineFees,
            int createdByUserID, bool isReleased, DateTime? releaseDate, int releasedByUserID, int? releaseApplicationID)
        {
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            this.CreatedByUserInfo = clsUser.Find(this.CreatedByUserID);
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            this.ReleasedByUserInfo = clsUser.FindByPersonID(this.ReleasedByUserID);
            ReleaseApplicationID = releaseApplicationID;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            DetainID = clsDetainedLicenseData.AddNewDetainedLicense(
                LicenseID, DetainDate, FineFees, CreatedByUserID,
                IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            return (DetainID != -1);
        }

        private bool _Update()
        {
            return clsDetainedLicenseData.UpdateDetainedLicense(
                DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
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

        public static clsDetainedLicense Find(int DetainID)
        {
            int LicenseID = -1; DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0; int CreatedByUserID = -1;
            bool IsReleased = false; DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1; int ReleaseApplicationID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByID(DetainID,
            ref LicenseID, ref DetainDate,
            ref FineFees, ref CreatedByUserID,
            ref IsReleased, ref ReleaseDate,
            ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicense(DetainID,
                     LicenseID, DetainDate,
                     FineFees, CreatedByUserID,
                     IsReleased, ReleaseDate,
                     ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }

        public static bool Delete(int detainID)
        {
            return clsDetainedLicenseData.DeleteDetainedLicense(detainID);
        }
        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1; DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0; int CreatedByUserID = -1;
            bool IsReleased = false; DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1; int ReleaseApplicationID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByLicenseID(LicenseID,
            ref DetainID, ref DetainDate,
            ref FineFees, ref CreatedByUserID,
            ref IsReleased, ref ReleaseDate,
            ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicense(DetainID,
                     LicenseID, DetainDate,
                     FineFees, CreatedByUserID,
                     IsReleased, ReleaseDate,
                     ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }

        public static DataTable GetAll()
        {
            return clsDetainedLicenseData.GetAllDetainedLicenses();
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseData.IsLicenseDetained(LicenseID);
        }

        public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetainedLicenseData.ReleaseDetainedLicense(this.DetainID,
                   ReleasedByUserID, ReleaseApplicationID);
        }
    }
}
