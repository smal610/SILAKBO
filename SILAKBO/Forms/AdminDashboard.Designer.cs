namespace SILAKBO
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnManageUsers = new Button();
            btnViewReports = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnManageUsers
            // 
            btnManageUsers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnManageUsers.Location = new Point(358, 70);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(426, 145);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnViewReports.Location = new Point(358, 247);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(426, 145);
            btnViewReports.TabIndex = 1;
            btnViewReports.Text = "View Reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLogout.Location = new Point(358, 422);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(426, 145);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboard
            // 
            ClientSize = new Size(1184, 641);
            Controls.Add(btnManageUsers);
            Controls.Add(btnViewReports);
            Controls.Add(btnLogout);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            ResumeLayout(false);
        }
    }
}