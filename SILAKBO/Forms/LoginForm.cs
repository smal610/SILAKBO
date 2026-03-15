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
            User user = new User();

            user.Username = txtUsername.Text;
            user.PasswordHash = PasswordHasher.Hash(txtPassword.Text);
            user.Role = "Victim";
            //user.Gender = cmbGender.Text;

            UserRepository repo = new UserRepository();
            repo.Register(user);

            MessageBox.Show("Account Registered Successfully!");
        }
    }
}
