using System.Data.SqlClient;

namespace PetStoreManagement.Data
{
    internal class Connection
    {
        // your host if in local use localhost
        private static readonly string server = "68.183.187.158";

        //your database name
        private static readonly string database = "school";

        //your username
        private static readonly string userId = "sa";

        //your password
        private static readonly string password = "Soknem@123";

        // Combine into a single connection string
        private static readonly string connectionString =
            $"Server={server};Database={database};User Id={userId};Password={password};";


        public static SqlConnection GetConnection()
        {

            //get connection to database
            var connection = new SqlConnection(connectionString);

            //open connection
            connection.Open();

            //return as sql connection 
            return connection;
        }
    }
}
