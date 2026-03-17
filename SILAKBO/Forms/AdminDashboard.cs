using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SILAKBO.Forms;

namespace SILAKBO
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            // Open a form to manage users (edit, delete, view)
            ManageUsersForm manageUsers = new ManageUsersForm();
            manageUsers.Show();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            // Open a form to view all reports submitted by victims
            ReportsForm reports = new ReportsForm();
            reports.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Logout Successful!", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
