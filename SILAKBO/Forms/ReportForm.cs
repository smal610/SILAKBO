using SILAKBO.BLL;
using SILAKBO.DAL;
using SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


//namespace SILAKBO.Forms
//{
//    public partial class ReportForm : Form
//    {
//        public ReportForm()
//        {
//            InitializeComponent();
//        }

//        private void btnBrowse_Click(object sender, EventArgs e)
//        {
//            OpenFileDialog open = new OpenFileDialog();

//            if (open.ShowDialog() == DialogResult.OK)
//            {
//                txtEvidence.Text = open.FileName;
//            }
//        }

//        private void btnSubmit_Click(object sender, EventArgs e)
//        {
//            if (cmbIncident.Text == "" || txtDescription.Text == "" || label4.Text == "")
//            {
//                MessageBox.Show("Please fill all required fields.");
//                return;
//            }

//            ReportService service = new ReportService();

//            service.Submit(
//                23, // UserID can be 0 if not used
//                "TestVictim", // pass victim name
//                cmbIncident.Text,
//                txtDescription.Text,
//                txtEvidence.Text
//            );

//            MessageBox.Show("Report submitted successfully!");

//            txtVictimName.Clear();
//            txtDescription.Clear();
//            txtEvidence.Clear();
//        }

//        private void txtEvidence_Click(object sender, EventArgs e)
//        {

//        }

//        private void label3_Click(object sender, EventArgs e)
//        {

//        }

//        private void txtEvidence_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}


//namespace SILAKBO.Forms
//{
//    public partial class ReportForm : Form
//    {
//        private User currentUser; // optional: for real login system

//        public ReportForm(User loggedInUser = null)
//        {
//            InitializeComponent();
//            currentUser = loggedInUser;
//        }

//        private void btnBrowse_Click(object sender, EventArgs e)
//        {
//            OpenFileDialog open = new OpenFileDialog();
//            if (open.ShowDialog() == DialogResult.OK)
//            {
//                txtEvidence.Text = open.FileName;
//            }
//        }

//        private void txtEvidence_Click(object sender, EventArgs e)
//        {
//            // optional: open file dialog or any logic
//            OpenFileDialog open = new OpenFileDialog();
//            if (open.ShowDialog() == DialogResult.OK)
//            {
//                txtEvidence.Text = open.FileName;
//            }
//        }

//        private void txtEvidence_TextChanged(object sender, EventArgs e)
//        {
//            // Optional: do something when txtEvidence changes
//            // For example, enable submit button
//            btnSubmit.Enabled = !string.IsNullOrWhiteSpace(txtEvidence.Text);
//        }

//        private void btnSubmit_Click(object sender, EventArgs e)
//        {
//            // Determine victim name
//            string victimName = currentUser != null ? currentUser.Username : txtVictimName.Text;

//            if (cmbIncident.Text == "" || txtDescription.Text == "" || string.IsNullOrWhiteSpace(victimName))
//            {
//                MessageBox.Show("Please fill all required fields.");
//                return;
//            }

//            ReportService service = new ReportService();

//            // Submit report
//            service.Submit(
//                currentUser != null ? currentUser.ID : 0, // UserID: 0 if no Users table yet
//                victimName,
//                cmbIncident.Text,
//                txtDescription.Text,
//                txtEvidence.Text
//            );

//            MessageBox.Show("Report submitted successfully!");

//            // Clear inputs
//            if (currentUser == null)
//                txtVictimName.Clear();

//            txtDescription.Clear();
//            txtEvidence.Clear();
//        }
//    }
//}



namespace SILAKBO.Forms
{
    public partial class ReportForm : Form
    {
        private User currentUser; // dynamic logged-in user

        public ReportForm(User loggedInUser = null)
        {
            InitializeComponent();
            currentUser = loggedInUser;
        }

        private void txtEvidence_Click(object sender, EventArgs e)
        {
            // optional: open file dialog or any logic
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtEvidence.Text = open.FileName;
            }
        }

        private void txtEvidence_TextChanged(object sender, EventArgs e)
        {
            // Optional: do something when txtEvidence changes
            // For example, enable submit button
            btnSubmit.Enabled = !string.IsNullOrWhiteSpace(txtEvidence.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
                txtEvidence.Text = open.FileName;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get victim name
            string victimName = currentUser != null ? currentUser.Username : txtVictimName.Text;

            if (cmbIncident.Text == "" || txtDescription.Text == "" || string.IsNullOrWhiteSpace(victimName))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            int userID;

            // If logged in, use current user ID
            if (currentUser != null)
            {
                userID = currentUser.ID;
            }
            else
            {
                // Check if victim exists in Users table
                userID = UserRepository.GetUserIDByUsername(victimName);

                // If not exist, create a new user
                if (userID == 0)
                {
                    userID = UserRepository.AddUser(victimName); // Returns the new ID
                }
            }

            // Now userID is guaranteed to exist in Users table
            ReportService service = new ReportService();
            service.Submit(userID, victimName, cmbIncident.Text, txtDescription.Text, txtEvidence.Text);

            MessageBox.Show("Report submitted successfully!");

            if (currentUser == null)
                txtVictimName.Clear();
            txtDescription.Clear();
            txtEvidence.Clear();
        }
    }
}