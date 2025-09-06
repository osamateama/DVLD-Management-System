using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsLicenseClass
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicenseClass()
        {
            LicenseClassID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 18;
            DefaultValidityLength = 10;
            ClassFees = 0;

            Mode = enMode.AddNew;
        }

        private clsLicenseClass(int licenseClassID, string className, string classDescription,
                                byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {
            LicenseClassID = licenseClassID;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            LicenseClassID = clsLicenseClassData.AddNewLicenseClass(ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            return (LicenseClassID != -1);
        }

        private bool _Update()
        {
            return clsLicenseClassData.UpdateLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
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
                    return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static clsLicenseClass Find(int licenseClassID)
        {
            string className = "", classDescription = "";
            byte minimumAllowedAge = 0, defaultValidityLength = 0;
            decimal classFees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByID(licenseClassID, ref className, ref classDescription,
                ref minimumAllowedAge, ref defaultValidityLength, ref classFees))
            {
                return new clsLicenseClass(licenseClassID, className, classDescription, minimumAllowedAge, defaultValidityLength, classFees);
            }
            else
            {
                return null;
            }
        }
        public static clsLicenseClass FindString(string className)
        {
            int licenseClassID = 0;
            string classDescription = "";
            byte minimumAllowedAge = 0, defaultValidityLength = 0;
            decimal classFees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByName(className, ref licenseClassID, ref classDescription,
                ref minimumAllowedAge, ref defaultValidityLength, ref classFees))
            {
                return new clsLicenseClass(licenseClassID, className, classDescription, minimumAllowedAge, defaultValidityLength, classFees);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAll()
        {
            return clsLicenseClassData.GetAllLicenseClasses();
        }

    }
}
