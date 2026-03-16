using MySql.Data.MySqlClient;
using SILAKBO.BLL;
using SILAKBO.DAL;
using SILAKBO.Forms;
using SILAKBO.Models;
using SILAKBO.Utils;

namespace SILAKBO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = Database.GetConnection();
                conn.Open();
                //MessageBox.Show("Database Connected Successfully!");
                //conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();

            User user = service.Login(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Login Successful!");

                if (user.Role == "Admin")
                {
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                }
                else
                {
                    VictimDashboard victim = new VictimDashboard();
                    victim.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Initialize the Register Form
            RegisterForm regForm = new RegisterForm();

            // 2. Show the Register Form
            regForm.Show();

            // 3. Hide the current Login Form
            this.Hide();
        }
    }
}
