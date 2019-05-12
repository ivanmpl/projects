using System.Configuration;
using System.Data.SqlClient;

class DBHelper
{
    public static string GetConnectionString()
    {
        // Build connection string
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "localhost";   // update me
        builder.UserID = "samplelogin";      // update me
        builder.Password = "Password123";   // update me
        builder.InitialCatalog = "master";
        return builder.ConnectionString;
    }
}