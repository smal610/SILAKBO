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
            if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up all fields.");
                return;
            }

            if (txtName.Text.Trim() == "" || txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            if (cmbGender.Text.Trim() == "")
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbGender.SelectedIndex == -1 ||
                dtpBirthday.Value == null)
            {
                MessageBox.Show("Please fill up all the fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserService service = new UserService();

            bool success = service.Register(
                txtName.Text.Trim(),
                txtUsername.Text,
                txtPassword.Text,
                cmbGender.Text,
                dtpBirthday.Value
            );

            if (success)
            {
                MessageBox.Show("Account created successfully!");

                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose another.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Find the open LoginForm or create a new one
            LoginForm login = new LoginForm();
            login.Show();
            this.Close(); // Close the register form to free up memory
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
