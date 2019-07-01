using System.Data.SqlClient;

/*
 * From nuget package: system.data.sqlclient
 */

public class ConnectionStringBuilder
{
    public string BuildConnectionString(string dbServerName, string dbDatabaseName, string dbUserId, string dbPassword, bool dbUseIntegratedSecurity)
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder("");

        builder.UserID = dbUserId;
        builder.Password = dbPassword;
        builder["server"] = dbServerName;
        builder["integrated Security"] = dbUseIntegratedSecurity;
        builder["Initial Catalog"] = dbDatabaseName;

        return builder.ConnectionString; 
    }
}