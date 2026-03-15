using MySql.Data.MySqlClient;

namespace SILAKBO.DAL
{
    public class Database
    {
        private static string connectionString =
            "server=localhost;database=silakbo_db;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}