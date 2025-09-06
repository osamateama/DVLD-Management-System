using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public int PersonID { get; set; }

        public clsPerson PersonInfo;
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            UserID = -1;
            UserName = "";
            Password = "";
            IsActive = true;
            Mode = enMode.AddNew;
        }

        private clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            this.PersonInfo = clsPerson.Find(personID);
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = enMode.Update;
        }

        public static clsUser Find(int userID)
        {
            int personID = -1;
            string userName = "", password = "";
            bool isActive = true;
            if (clsUsersData.GetUserInfoByID(userID, ref personID, ref userName, ref password, ref isActive))
                return new clsUser(userID, personID, userName, password, isActive);

            return null;
        }

        public static clsUser FindByPersonID(int personID)
        {
            int userID = -1;
            string userName = "", password = "";
            bool isActive = true;
            if (clsUsersData.GetUserInfoByPersonID(personID, ref userID, ref userName, ref password, ref isActive))
                return new clsUser(userID, personID, userName, password, isActive);

            return null;
        }
        public static clsUser FindByUserNameAndPassword(string userName, string password)
        {
            int UserID = -1;
            int PersonID = -1;
            bool isActive = true;
            if(clsUsersData.GetUserInfoByUserNameAndPassword(userName, password, ref PersonID,ref UserID,ref isActive))
                return new clsUser(UserID, PersonID, userName, password, isActive);
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

                default:
                    return false;
            }
        }

        private bool _AddNew()
        {
            UserID = clsUsersData.AddNewUser(PersonID, UserName, Password, IsActive);
            return (UserID != -1);
        }

        private bool _Update()
        {
            return clsUsersData.UpdateUser(UserID, PersonID, UserName, Password, IsActive);
        }

        public bool Delete()
        {
            return clsUsersData.DeleteUser(UserID);
        }

        public static bool IsExist(int userID)
        {
            return clsUsersData.IsUserExist(userID);
        }
        public static bool IsExist(string UserName)
        {
            return clsUsersData.IsUserExist(UserName);
        }
        public static bool IsUserExistUsePersonID(int PersonID)
        {
            return clsUsersData.IsUserExistUsePersonID(PersonID);
        }
        public static bool DeleteUser(int userID)
        {
            return clsUsersData.DeleteUser(userID);
        }
        public static DataTable GetAll()
        {
            return clsUsersData.GetAllUsers();
        }
        public static bool ChangePassword(int UserID, string NewPassword)
        {
            return clsUsersData.ChangePassword(UserID, NewPassword);
        }
    }
}
