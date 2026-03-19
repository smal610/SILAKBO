using SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SILAKBO.Forms
{
    public partial class VictimDashboard : Form
    {

        private string loggedInUsername; // store username
        private User currentUser;

        public VictimDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
            loggedInUsername = user.Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.Show();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            ResourcesForm resources = new ResourcesForm();
            resources.Show();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            TrackCaseForm form = new TrackCaseForm(currentUser);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Ask the user for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Show logout success message
                MessageBox.Show("Logout successful!", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to login form
                LoginForm login = new LoginForm();
                login.Show();

                // Close current dashboard
                this.Close();
            }
            // If No is selected, do nothing and stay on dashboard
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(loggedInUsername);
            profile.ShowDialog(); // modal form
        }
    }
}
