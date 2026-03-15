using MySql.Data.MySqlClient;
using SILAKBO.DAL;
using SILAKBO.Utils; // for PasswordHasher
using System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SILAKBO
{
    public class TestAdminInsert
    {
        public static void Run()
        {
            try
            {
                // Use the same connection your LoginForm uses
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string username = "admin";
                    string password = "Admin123";
                    string hashedPassword = PasswordHasher.Hash(password);
                    string role = "Admin";

                    string query = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@username, @password, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@role", role);

                    int rows = cmd.ExecuteNonQuery(); // returns number of rows affected

                    if (rows > 0)
                        MessageBox.Show("Admin inserted successfully!");
                    else
                        MessageBox.Show("Insert failed. Check table/columns.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}