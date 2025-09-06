using BusinessLayer;
using System;
using Microsoft.Win32;

namespace DVLD
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;

        private const string RegistryPath = @"Software\DVDL_LoginInfo";

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
                {
                    if (string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password))
                    {
                        key.DeleteValue("Username", false);
                        key.DeleteValue("Password", false);
                    }
                    else
                    {
                        key.SetValue("Username", Username);
                        key.SetValue("Password", Password);
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
                {
                    if (key != null)
                    {
                        object userObj = key.GetValue("Username");
                        object passObj = key.GetValue("Password");

                        if (userObj != null && passObj != null)
                        {
                            Username = userObj.ToString();
                            Password = passObj.ToString();
                            return true;
                        }
                    }
                }
            }
            catch
            {
            }

            Username = "";
            Password = "";
            return false;
        }
    }
}
