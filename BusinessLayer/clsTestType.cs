using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest =1,WrittenTest = 2 ,StreeTest=3};
        public clsTestType.enTestType TestTypeID { get;  set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }
        public clsTestType()
        {
            TestTypeID = clsTestType.enTestType.VisionTest;
            TestTypeTitle = string.Empty;
            TestTypeDescription = string.Empty;
            TestTypeFees = 0;
            Mode = enMode.AddNew;
        }
        private clsTestType(clsTestType.enTestType testTypeID, string title, string description, decimal fees)
        {
            TestTypeID = testTypeID;
            TestTypeTitle = title;
            TestTypeDescription = description;
            TestTypeFees = fees;
            Mode = enMode.Update;
        }
        public static clsTestType Find(clsTestType.enTestType testTypeID)
        {
            string title = "", description = "";
            decimal fees = 0;

            if (clsTestTypesData.GetTestTypeInfoByID((int)testTypeID, ref title, ref description, ref fees))
            {
                return new clsTestType((clsTestType.enTestType) testTypeID, title, description, fees);
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return _AddNew();
                case enMode.Update:
                    return _Update();
            }
            return false;
        }
        private bool _AddNew()
        {
            TestTypeID =(clsTestType.enTestType) clsTestTypesData.AddNewTestType(TestTypeTitle, TestTypeDescription, TestTypeFees);
            return (TestTypeTitle != "");
        }
        private bool _Update()=> clsTestTypesData.UpdateTestType((int)TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        public static DataTable GetAll()=> clsTestTypesData.GetAllTestTypes();
    }
}
