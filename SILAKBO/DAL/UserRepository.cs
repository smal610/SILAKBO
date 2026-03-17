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
                    Gender = reader["Gender"].ToString()
                };
            }

            conn.Close();
            return user;
        }
    }
}