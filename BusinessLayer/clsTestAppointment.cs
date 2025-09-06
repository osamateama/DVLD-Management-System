using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { set; get; }
        public clsTestType.enTestType TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public clsApplication RetakeTestAppInfo { set; get; }

        public int TestID
        {
            get { return _GetTestID(); }

        }

        public clsTestAppointment()

        {
            this.TestAppointmentID = -1;
            this.TestTypeID = clsTestType.enTestType.VisionTest;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;

        }

        public clsTestAppointment(int TestAppointmentID, clsTestType.enTestType TestTypeID,
           int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees,
           int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)

        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestAppInfo = clsApplication.Find(RetakeTestApplicationID);
            Mode = enMode.Update;
        }


        private bool _AddNew()
        {
            TestAppointmentID = clsTestAppointmentsData.AddNewAppointment((int)TestTypeID, LocalDrivingLicenseApplicationID,
                AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            return (TestAppointmentID != -1);
        }

        private bool _Update()
        {
            return clsTestAppointmentsData.UpdateAppointment(TestAppointmentID, (int)TestTypeID, LocalDrivingLicenseApplicationID,
                AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
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

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = 1; int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now; decimal PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsTestAppointmentsData.GetAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
            ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointment(TestAppointmentID, (clsTestType.enTestType)TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }

        public static bool Delete(int testAppointmentID)
        {
            return clsTestAppointmentsData.DeleteAppointment(testAppointmentID);
        }

        public static bool IsExist(int testAppointmentID)
        {
            return clsTestAppointmentsData.IsAppointmentExist(testAppointmentID);
        }

        public static DataTable GetAll()
        {
            return clsTestAppointmentsData.GetAllAppointments();
        }
        private int _GetTestID()
        {
            return clsTestAppointmentsData.GetTestID(TestAppointmentID);
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentsData.GetAllAppointments();

        }


        public DataTable GetApplicationTestAppointmentsPerTestType(clsTestType.enTestType TestTypeID)
        {
            return clsTestAppointmentsData.GetApplicationTestAppointmentsPerTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);

        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsTestAppointmentsData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        }
        public static clsTestAppointment GetLastTestAppointment(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now; decimal PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsTestAppointmentsData.GetLastTestAppointment(LocalDrivingLicenseApplicationID, (int)TestTypeID,
                ref TestAppointmentID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }
        public static bool LockTestAppointment(int TestAppointmentID)
        {
            return clsTestAppointmentsData.LockAppointment(TestAppointmentID);
        }

    }
}
