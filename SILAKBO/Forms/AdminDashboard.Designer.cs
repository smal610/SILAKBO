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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            btnManageUsers = new Button();
            btnViewReports = new Button();
            btnLogout = new Button();
            btnTrackCases = new Button();
            btnViewResources = new Button();
            pictureBox1 = new PictureBox();
            dgvReports = new DataGridView();
            ReportID = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            DateSubmitted = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // btnManageUsers
            // 
            btnManageUsers.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            btnManageUsers.Location = new Point(593, 106);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(259, 68);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            btnViewReports.Location = new Point(63, 106);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(259, 68);
            btnViewReports.TabIndex = 1;
            btnViewReports.Text = "View Reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1064, 30);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(87, 32);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTrackCases
            // 
            btnTrackCases.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            btnTrackCases.Location = new Point(328, 106);
            btnTrackCases.Name = "btnTrackCases";
            btnTrackCases.Size = new Size(259, 68);
            btnTrackCases.TabIndex = 3;
            btnTrackCases.Text = "Track Cases";
            btnTrackCases.UseVisualStyleBackColor = true;
            // 
            // btnViewResources
            // 
            btnViewResources.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            btnViewResources.Location = new Point(858, 106);
            btnViewResources.Name = "btnViewResources";
            btnViewResources.Size = new Size(259, 68);
            btnViewResources.TabIndex = 4;
            btnViewResources.Text = "View Support Resources";
            btnViewResources.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 51);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = Color.White;
            dgvReports.BorderStyle = BorderStyle.None;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { ReportID, User, DateSubmitted, Status, Actions });
            dgvReports.Location = new Point(63, 206);
            dgvReports.Name = "dgvReports";
            dgvReports.Size = new Size(1054, 304);
            dgvReports.TabIndex = 6;
            // 
            // ReportID
            // 
            ReportID.HeaderText = "ReportID";
            ReportID.Name = "ReportID";
            // 
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            // 
            // DateSubmitted
            // 
            DateSubmitted.HeaderText = "DateSubmitted";
            DateSubmitted.Name = "DateSubmitted";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.Name = "Actions";
            // 
            // AdminDashboard
            // 
            ClientSize = new Size(1184, 641);
            Controls.Add(dgvReports);
            Controls.Add(pictureBox1);
            Controls.Add(btnViewResources);
            Controls.Add(btnTrackCases);
            Controls.Add(btnManageUsers);
            Controls.Add(btnViewReports);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        private Button btnTrackCases;
        private Button btnViewResources;
        private PictureBox pictureBox1;
        private DataGridView dgvReports;
        private DataGridViewTextBoxColumn ReportID;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn DateSubmitted;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Actions;
    }
}