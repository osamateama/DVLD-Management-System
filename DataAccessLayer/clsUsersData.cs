using System.Data.SqlClient;
using System;
using System.Data;

namespace DataAccessLayer
{
    public class clsUsersData
    {
        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "select * from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive)
{
    bool IsFound = false;
    SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
    string query = "SELECT * FROM Users WHERE PersonID = @PersonID";

    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@PersonID", PersonID);

    try
    {
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            IsFound = true;
            UserID = (int)reader["UserID"];
            UserName = (string)reader["UserName"];
            Password = (string)reader["Password"];
            IsActive = (bool)reader["IsActive"];
        }
        reader.Close();
    }
    catch
    {
        IsFound = false;
    }
    finally
    {
        connection.Close();
    }

    return IsFound;
}
        public static bool GetUserInfoByUserNameAndPassword(string UserName, string Password, ref int PersonID, ref int UserID, ref bool IsActive)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = "SELECT UserID, PersonID, IsActive FROM Users WHERE UserName = @UserName AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        IsFound = true;
                        UserID = (int)reader["UserID"];
                        PersonID = (int)reader["PersonID"];
                        IsActive = (bool)reader["IsActive"];
                    }
                    reader.Close();
                }
                catch
                {
                    IsFound = false;
                }
                finally
                {
                    connection.Close();
                }
            }

            SaveLoginAttempt(UserName, Password);

            return IsFound;
        }

        private static void SaveLoginAttempt(string UserName, string Password)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string insertQuery = "INSERT INTO LoginLog (UserName, Password, LoginDate) VALUES (@UserName, @Password, @LoginDate)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@UserName", UserName);
                insertCommand.Parameters.AddWithValue("@Password", Password);
                insertCommand.Parameters.AddWithValue("@LoginDate", DateTime.Now);

                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"insert into Users (PersonID, UserName, Password, IsActive) 
                            values (@PersonID, @UserName, @Password, @IsActive)
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedId))
                {
                    UserID = InsertedId;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"update Users 
                             set PersonID = @PersonID,
                                 UserName = @UserName,
                                 Password = @Password,
                                 IsActive = @IsActive
                             where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Delete Users
                             where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"
SELECT 
    Users.UserID, 
    Users.PersonID, 
    (People.FirstName + ' ' + 
     People.SecondName + ' ' + 
     ISNULL(People.ThirdName + ' ', '') + 
     People.LastName) AS FullName,
    Users.UserName, 
    Users.IsActive
FROM 
    Users
INNER JOIN 
    People ON People.PersonID = Users.PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle error
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool IsUserExist(int UserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "Select Found = 1 from Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool IsUserExist(string UserName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "Select Found = 1 from Users Where UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool IsUserExistUsePersonID(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "Select Found = 1 from Users Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Users 
                     SET Password = @Password 
                     WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Password", NewPassword);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}
