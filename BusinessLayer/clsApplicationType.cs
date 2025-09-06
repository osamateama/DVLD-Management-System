using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsApplicationType
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }
        public clsApplicationType()
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = "";
            ApplicationFees = 0;

            Mode = enMode.AddNew;
        }
        private clsApplicationType(int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
        {
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypeTitle;
            ApplicationFees = applicationFees;

            Mode = enMode.Update;
        }
        private bool _AddNewApplicationType()
        {
            ApplicationTypeID = clsApplicationTypeData.AddNewApplicationType(ApplicationTypeTitle, ApplicationFees);
            return (ApplicationTypeID != -1);
        }
        private bool _UpdateApplicationType()=>clsApplicationTypeData.UpdateApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateApplicationType();
            }

            return false;
        }

        public static clsApplicationType Find(int applicationTypeID)
        {
            string applicationTypeTitle = "";
            decimal applicationFees = 0;

            if (clsApplicationTypeData.GetApplicationTypeInfoByID(applicationTypeID, ref applicationTypeTitle, ref applicationFees))
            {
                return new clsApplicationType(applicationTypeID, applicationTypeTitle, applicationFees);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllApplicationTypes()=> clsApplicationTypeData.GetAllApplicationTypes();

        public static bool IsApplicationTypeExist(int applicationTypeID) => clsApplicationTypeData.IsApplicationTypeExist(applicationTypeID);
          
    }
}
