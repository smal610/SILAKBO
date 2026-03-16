namespace SILAKBO.Forms
{
    partial class VictimDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VictimDashboard));
            btnReport = new Button();
            btnResources = new Button();
            btnTrack = new Button();
            btnLogout = new Button();
            btnProfile = new Button();
            SuspendLayout();
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnReport.Location = new Point(594, 197);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(353, 116);
            btnReport.TabIndex = 1;
            btnReport.Text = "Submit Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnResources
            // 
            btnResources.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnResources.Location = new Point(594, 344);
            btnResources.Name = "btnResources";
            btnResources.Size = new Size(353, 116);
            btnResources.TabIndex = 2;
            btnResources.Text = "View Support Resources";
            btnResources.UseVisualStyleBackColor = true;
            btnResources.Click += btnResources_Click;
            // 
            // btnTrack
            // 
            btnTrack.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnTrack.Location = new Point(191, 344);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(353, 116);
            btnTrack.TabIndex = 3;
            btnTrack.Text = "Track Case";
            btnTrack.UseVisualStyleBackColor = true;
            btnTrack.Click += btnTrack_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1020, 61);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 35);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(191, 197);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(353, 116);
            btnProfile.TabIndex = 5;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += button1_Click;
            // 
            // VictimDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 641);
            Controls.Add(btnProfile);
            Controls.Add(btnLogout);
            Controls.Add(btnTrack);
            Controls.Add(btnResources);
            Controls.Add(btnReport);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VictimDashboard";
            Text = "VictimDashboard";
            ResumeLayout(false);
        }

        #endregion
        private Button btnReport;
        private Button btnResources;
        private Button btnTrack;
        private Button btnLogout;
        private Button btnProfile;
    }
}