using System.Configuration;
using System.Data;
using System.Data.Common;

namespace teacher_attendance_DB_hw5.libraries
{
    class DatabaseConnection
    {

        // Caches the connection string
        private static string DbConnectionString;
        // Caches the data provider name 
        private static string DbProviderName;



        static DatabaseConnection()
        {

            DbConnectionString = ConfigurationManager.ConnectionStrings["Teacher_attendanceconnectionStrings"].ConnectionString;
            DbProviderName = ConfigurationManager.ConnectionStrings["Teacher_attendanceconnectionStrings"].ProviderName;
        }

        public static DbCommand getConnection()
        {

            DbProviderFactory factory = DbProviderFactories.GetFactory(DbProviderName);
            // Obtain a database specific connection object
            DbConnection conn = factory.CreateConnection();
            // Set the connection string
            conn.ConnectionString = DbConnectionString;
            // Create a database specific command object
            return conn.CreateCommand();
        }

    }
}

