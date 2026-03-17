using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SILAKBO.BLL;
using SILAKBO.Models;

namespace SILAKBO.Forms
{
    public partial class ProfileForm : Form
    {
        private string _username;
        private UserService _userService = new UserService();

        public ProfileForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            User user = _userService.GetUserByUsername(_username);
            if (user != null)
            {
                lblName.Text = user.Name;
                lblUsername.Text = user.Username;
                lblGender.Text = user.Gender;
                lblBirthday.Text = user.Birthday.ToString("yyyy-MM-dd");
                lblRole.Text = user.Role;
            }
            else
            {
                MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}