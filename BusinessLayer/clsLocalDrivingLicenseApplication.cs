using System;
using System.Data;
using DataAccessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLicenseClass LicenseClassInfo;
        public string FullName
        {
            get { return base.PersonInfo?.FullName ?? "N/A"; }
        }

        public clsApplication ApplicationInfo;

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;


            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID, int LicenseClassID)

        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID; 
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.Find(ApplicationID);
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int)ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsData.AddNewApplication(ApplicationID, LicenseClassID);
            return (LocalDrivingLicenseApplicationID != -1);
        }

        private bool _Update()
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
        }
        public bool Save()
        {

            //Because of inheritance first we call the save method in the base class,
            //it will take care of adding all information to the application table.
            base.Mode = (clsApplication.enMode)Mode;
            if (!base.Save())
                return false;


            //After we save the main application now we save the sub application.
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _Update();

            }

            return false;
        }


        public static clsLocalDrivingLicenseApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationsData.GetLocalDrivingLicenseApplicationInfoByID
                (LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);

            if (IsFound)
            {
                clsApplication Application = clsApplication.Find(ApplicationID);

                if (Application == null)
                    return null;

                return new clsLocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                    Application.ApplicationDate, Application.ApplicationTypeID,
                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }



        public static clsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
            // 
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationsData.GetLocalApplicationInfoByApplicationID 
                (ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application
                clsApplication Application = clsApplication.Find(ApplicationID);

                //we return new object of that person with the right data
                return new clsLocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }
            else
                return null;


        }


        public bool Delete()
        {
            bool IsLocalDrivingApplicationDeleted = false;
            bool IsBaseApplicationDeleted = false;
            //First we delete the Local Driving License Application
            IsLocalDrivingApplicationDeleted = clsLocalDrivingLicenseApplicationsData.DeleteApplication(this.LocalDrivingLicenseApplicationID);

            if (!IsLocalDrivingApplicationDeleted)
                return false;
            //Then we delete the base Application
            IsBaseApplicationDeleted = base.DeleteApplication();
            return IsBaseApplicationDeleted;

        }

        public static DataTable GetAll()
        {
            return clsLocalDrivingLicenseApplicationsData.GetAllApplications();
        }

        public static bool IsExist(int localDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsData.IsApplicationExist(localDrivingLicenseApplicationID);
        }

        public bool DoesAttendTestType(clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsData.DoesPassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public byte TotalTrialsPerTest(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static bool AttendedTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }

        public bool AttendedTest(clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplicationsData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(clsTestType.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplicationsData.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public bool DoesPassTestType(clsTestType.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsData.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public byte GetPassedTestCount()
        {
            return clsTests.GetPassedTestCount(this.LocalDrivingLicenseApplicationID);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTests.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public clsTests GetLastTestPerTestType(clsTestType.enTestType TestTypeID)
        {
            return clsTests.FindLastTestPerPersonAndLicenseClass(this.ApplicantPersonID, this.LicenseClassID, TestTypeID);
        }
        public bool PassedAllTests()
        {
            return clsTests.PassedAllTests(this.LocalDrivingLicenseApplicationID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            return clsTests.PassedAllTests(LocalDrivingLicenseApplicationID);
        }
        public int GetActiveLicenseID()
        {//this will get the license id that belongs to this application
            return clsLicense.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }
        public bool IsLicenseIssued()
        {
            return (GetActiveLicenseID() != -1);
        }
        public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID)
        {
            int DriverID = -1;

            clsDriver Driver = clsDriver.FindByPersonID(this.ApplicantPersonID);

            if (Driver == null)
            {
                Driver = new clsDriver();
                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedByUserID = CreatedByUserID;

                if (Driver.Save())
                    DriverID = Driver.DriverID;
                else
                    return -1;
            }
            else
            {
                DriverID = Driver.DriverID;
            }

            clsLicense License = new clsLicense();
            License.ApplicationID = this.ApplicationID;
            License.DriverID = DriverID;
            License.LicenseClassID = this.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = this.LicenseClassInfo.ClassFees;
            License.IsActive = true;
            License.IssueReason = clsLicense.enIssueReason.FirstTime;
            License.CreatedByUserID = CreatedByUserID;

            if (License.Save())
            {
                this.SetComplet(); 
                return License.LicenseID;
            }

            return -1;
        }
     

    }
}
