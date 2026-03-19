using MySql.Data.MySqlClient;
using SILAKBO.Models;
using System;

namespace SILAKBO.DAL
{
    public class UserRepository
    {
        public void Register(User user)
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Users
                            (Name, Username, PasswordHash, Role, Gender, Birthday)
                            VALUES
                            (@Name, @Username, @PasswordHash, @Role, @Gender, @Birthday)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            cmd.Parameters.AddWithValue("@Gender", user.Gender);
            cmd.Parameters.AddWithValue("@birthday", user.Birthday);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public bool UsernameExists(string username)
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM Users WHERE Username=@Username";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }


        // NEW METHOD FOR LOGIN
        public User GetUserByUsername(string username)
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Users WHERE Username = @Username";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);

            MySqlDataReader reader = cmd.ExecuteReader();

            User user = null;

            if (reader.Read())
            {
                user = new User
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Username = reader["Username"].ToString(),
                    PasswordHash = reader["PasswordHash"].ToString(),
                    Role = reader["Role"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    Name = reader["Name"].ToString ()
                };
            }

            conn.Close();
            return user;
        }

        public static int GetUserIDByUsername(string username)
        {
            int userID = 0;
            var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT ID FROM Users WHERE Username=@Username LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);

            var result = cmd.ExecuteScalar();
            if (result != null)
                userID = Convert.ToInt32(result);

            conn.Close();
            return userID;
        }

        public static int AddUser(string username)
        {
            int newID = 0;
            var conn = Database.GetConnection();
            conn.Open();

            // Insert user with minimal required data for reports
            string query = "INSERT INTO Users (Username) VALUES (@Username)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();

            // Get the auto-generated ID
            cmd.CommandText = "SELECT LAST_INSERT_ID()";
            newID = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return newID;
        }
    }
}