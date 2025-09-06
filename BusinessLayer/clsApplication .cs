using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public enum enApplicationType { NewDrivingLicense=1, RenewDrivingLicense=2, ReplacementForaLostDrivingLicense = 3,
                                    ReplacementForaDamagedDrivingLicense =4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6,
                                    RetakeTest = 8}
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3}

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public string ApplicationFullName
        {
            get { return clsPerson.Find(PersonInfo.ID).FullName; }
        }

        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationType ApplicationTypeInfo { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public string TextStatus
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "UnKnown";
                }
            }
        }

        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; set; }

        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = enApplicationStatus.New ;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsApplication(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID,
            enApplicationStatus applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            this.ApplicationID = applicationID;
            this.ApplicantPersonID = applicantPersonID;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);
            this.ApplicationStatus = applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.CreatedByUserInfo = clsUser.Find(createdByUserID);

            Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            ApplicationID = clsApplicationData.AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID,
               (byte) ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return (ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                (byte)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateApplication();
            }

            return false;
        }

        public static clsApplication Find(int applicationID)
        {
            int applicantPersonID = -1, applicationTypeID = -1, createdByUserID = -1;
            byte applicationStatus = 0;
            decimal paidFees = 0;
            DateTime applicationDate = DateTime.Now;
            DateTime lastStatusDate = DateTime.Now;

            if (clsApplicationData.GetApplicationInfoByID(applicationID, ref applicantPersonID, ref applicationDate,
                ref applicationTypeID, ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID))
            {
                return new clsApplication(applicationID, applicantPersonID, applicationDate, applicationTypeID,
                   (enApplicationStatus) applicationStatus, lastStatusDate, paidFees, createdByUserID);
            }
            else
            {
                return null;
            }
        }

        public  bool DeleteApplication()
        {
            return clsApplicationData.DeleteApplication(this.ApplicationID);
        }

        public static DataTable GetAllApplications()
        {
            return clsApplicationData.GetAllApplications();
        }

        public static bool IsApplicationExist(int applicationID)
        {
            return clsApplicationData.IsApplicationExist(applicationID);
        }

        public bool Cancelled()
        {
            return (clsApplicationData.UpdateStatus(ApplicationID, 2));
        }
        public bool SetComplet()
        {
            return (clsApplicationData.UpdateStatus(ApplicationID, 3));
        }

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
        }

        public bool DoesPersonHaveActiveApplication(int ApplicationTypeID)
        {
            return DoesPersonHaveActiveApplication(this.ApplicantPersonID, ApplicationTypeID);
        }

        public static int GetActiveApplicationID(int PersonID, clsApplication.enApplicationType ApplicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplication.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }

        public int GetActiveApplicationID(clsApplication.enApplicationType ApplicationTypeID)
        {
            return GetActiveApplicationID(this.ApplicantPersonID, ApplicationTypeID);
        }

    }
}
