using SILAKBO.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SILAKBO.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            try
            {
                UserService service = new UserService();

                service.Register(txtUsername.Text, txtPassword.Text);

                MessageBox.Show("Account created successfully!");

                txtUsername.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Find the open LoginForm or create a new one
            LoginForm login = new LoginForm();
            login.Show();
            this.Close(); // Close the register form to free up memory
        }
    }
}
