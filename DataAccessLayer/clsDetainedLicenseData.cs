using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsDetainedLicenseData
    {
        public static bool GetDetainedLicenseInfoByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees,
            ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "select * from DetainedLicenses where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    else
                        ReleaseDate = default;
                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = -1;
                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = -1;
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

        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref decimal FineFees,
    ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT TOP 1 * 
                            FROM DetainedLicenses 
                            WHERE LicenseID = @LicenseID 
                            ORDER BY DetainDate DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    ReleaseDate = reader["ReleaseDate"] != DBNull.Value ? (DateTime)reader["ReleaseDate"] : default;
                    ReleasedByUserID = reader["ReleasedByUserID"] != DBNull.Value ? (int)reader["ReleasedByUserID"] : -1;
                    ReleaseApplicationID = reader["ReleaseApplicationID"] != DBNull.Value ? (int)reader["ReleaseApplicationID"] : -1;
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


        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
     bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int DetainID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
            INSERT INTO DetainedLicenses 
            (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) 
            VALUES 
            (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);
            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    command.Parameters.AddWithValue("@DetainDate", DetainDate);
                    command.Parameters.AddWithValue("@FineFees", FineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@IsReleased", IsReleased);

                    if (ReleaseDate.HasValue && ReleaseDate.Value != DateTime.MaxValue)
                        command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                    else
                        command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

                    if (ReleasedByUserID.HasValue && ReleasedByUserID > 0)
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                    else
                        command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

                    if (ReleaseApplicationID.HasValue && ReleaseApplicationID > 0)
                        command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
                    else
                        command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedId))
                        {
                            DetainID = InsertedId;
                        }
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                }
            }
            return DetainID;
        }

        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"update DetainedLicenses 
                             set LicenseID = @LicenseID,
                                 DetainDate = @DetainDate,
                                 FineFees = @FineFees,
                                 CreatedByUserID = @CreatedByUserID,
                                 IsReleased = @IsReleased,
                                 ReleaseDate = @ReleaseDate,
                                 ReleasedByUserID = @ReleasedByUserID,
                                 ReleaseApplicationID = @ReleaseApplicationID
                             where DetainID = @DetainID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (ReleaseDate.HasValue)
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            if (ReleasedByUserID.HasValue)
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            if (ReleaseApplicationID.HasValue)
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteDetainedLicense(int DetainID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Delete DetainedLicenses
                             where DetainID = @DetainID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "select * from DetainedLicenses_View order by IsReleased ,DetainID";

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
                //
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static bool ReleaseDetainedLicense(int DetainID,
                         int ReleasedByUserID, int ReleaseApplicationID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE dbo.DetainedLicenses
                              SET IsReleased = 1, 
                              ReleaseDate = @ReleaseDate, 
                              ReleasedByUserID = @ReleasedByUserID,
                              ReleaseApplicationID = @ReleaseApplicationID   
                              WHERE DetainID=@DetainID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select IsDetained=1 
                            from detainedLicenses 
                            where 
                            LicenseID=@LicenseID 
                            and IsReleased=0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsDetained = Convert.ToBoolean(result);
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


            return IsDetained;
            ;

        }

    }
}
