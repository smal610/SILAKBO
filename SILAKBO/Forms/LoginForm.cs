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
            
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // CHECK EMPTY INPUTS FIRST
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            UserService service = new UserService();

            User user = service.Login(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Login Successful!");

                if (user.Role == "Admin")
                {
                    AdminReportViewer admin = new AdminReportViewer();
                    admin.Show();
                }
                else
                {
                    VictimDashboard victim = new VictimDashboard(user.Username);
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

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // hide password
            }
        }
    }
}
