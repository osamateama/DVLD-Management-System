using System.Configuration;

namespace DataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string connectionString =>
             ConfigurationManager.ConnectionStrings["DVLD"].ConnectionString;
    }
}
