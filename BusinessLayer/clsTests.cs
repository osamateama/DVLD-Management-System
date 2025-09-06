using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTests
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        public int TestID { get; private set; }
        public int TestAppointmentID { get; set; }
        public clsTestAppointment TestAppointmentInfo { set; get; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTests()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsTests(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            this.TestAppointmentInfo = clsTestAppointment.Find(TestAppointmentID);
            Notes = notes;
            CreatedByUserID = createdByUserID;

            Mode = enMode.Update;
        }

        public static clsTests Find(int testID)
        {
            int testAppointmentID = -1;
            bool testResult = false;
            string notes = "";
            int createdByUserID = -1;

            if (clsTestsData.GetTestInfoByID(testID, ref testAppointmentID, ref testResult, ref notes, ref createdByUserID))
            {
                return new clsTests(testID, testAppointmentID, testResult, notes, createdByUserID);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            bool success = false;

            switch (Mode)
            {
                case enMode.AddNew:
                    success = _AddNew();
                    break;
                case enMode.Update:
                    success = _Update();
                    break;
            }

            if (success && TestResult == false)
            {
                clsTestAppointment.LockTestAppointment(TestAppointmentID);
            }

            return success;
        }

        private bool _AddNew()
        {
            TestID = clsTestsData.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return (TestID != -1);
        }

        private bool _Update()
        {
            return clsTestsData.UpdateTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        public bool Delete()
        {
            return clsTestsData.DeleteTest(TestID);
        }

        public static bool IsTestExist(int testID)
        {
            return clsTestsData.IsTestExist(testID);
        }

        public static DataTable GetAllTests()
        {
            return clsTestsData.GetAllTests();
        }
        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTestsData.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }
        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            return GetPassedTestCount(LocalDrivingLicenseApplicationID) == 3;
        }
        public static clsTests FindLastTestPerPersonAndLicenseClass(int PersonID, int LicenseClassID, clsTestType.enTestType TestTypeID)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

            if (clsTestsData.GetLastTestByPersonAndTestTypeAndLicenseClass(PersonID,LicenseClassID,(int) TestTypeID, ref TestID,ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new clsTests(TestID,TestAppointmentID, TestResult,Notes, CreatedByUserID);
            else
                return null;

        }
        
    }
}
