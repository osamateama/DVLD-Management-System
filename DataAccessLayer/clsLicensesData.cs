using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsLicensesData
    {
        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID,
            ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
            ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            ApplicationID = (int)reader["ApplicationID"];
                            DriverID = (int)reader["DriverID"];
                            LicenseClass = (int)reader["LicenseClass"];
                            IssueDate = (DateTime)reader["IssueDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
                            PaidFees = (decimal)reader["PaidFees"];
                            IsActive = (bool)reader["IsActive"];
                            IssueReason = (byte)reader["IssueReason"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];

                            Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";
                        }
                        reader.Close();
                    }
                    catch { IsFound = false; }
                }
            }
            return IsFound;
        }

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"INSERT INTO Licenses 
                                (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                                 VALUES
                                (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                    command.Parameters.AddWithValue("@IssueDate", IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@IssueReason", IssueReason);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            LicenseID = insertedID;
                        }
                    }
                    catch { }
                }
            }
            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive,
            byte IssueReason, int CreatedByUserID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"UPDATE Licenses SET 
                                 ApplicationID = @ApplicationID,
                                 DriverID = @DriverID,
                                 LicenseClass = @LicenseClass,
                                 IssueDate = @IssueDate,
                                 ExpirationDate = @ExpirationDate,
                                 Notes = @Notes,
                                 PaidFees = @PaidFees,
                                 IsActive = @IsActive,
                                 IssueReason = @IssueReason,
                                 CreatedByUserID = @CreatedByUserID
                                 WHERE LicenseID = @LicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                    command.Parameters.AddWithValue("@IssueDate", IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@IssueReason", IssueReason);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            return (rowsAffected > 0);
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClass)
        {
            int LicenseID = -1;
            string query = @"
            SELECT Licenses.LicenseID
            FROM Licenses
            INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
            WHERE Licenses.LicenseClass = @LicenseClass
              AND Drivers.PersonID = @PersonID
              AND Licenses.IsActive = 1";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@LicenseClass", LicenseClass);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                        LicenseID = id;
                }
                catch { }
            }
            return LicenseID;
        }

        public static bool DeactivateLicense(int LicenseID)
        {
            int rowsAffected = 0;
            string query = "UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LicenseID", LicenseID);
                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch { }
            }
            return (rowsAffected > 0);
        }
        public static DataTable GetDriverLicenses(int DriverID)
        {
            DataTable dt = new DataTable();

            string query = @"SELECT 
        Licenses.LicenseID,
        ApplicationID,
        LicenseClasses.ClassName,
        Licenses.IssueDate,
        Licenses.ExpirationDate,
        Licenses.IsActive
    FROM Licenses
    INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
    WHERE DriverID = @DriverID
    ORDER BY IsActive DESC, ExpirationDate DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                // ممكن تسجل اللوج هنا لو حبيت
            }

            return dt;
        }

    }
}
