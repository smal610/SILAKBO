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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.LightSkyBlue;
            btnReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnReport.Location = new Point(594, 197);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(353, 116);
            btnReport.TabIndex = 1;
            btnReport.Text = "Submit Report";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnResources
            // 
            btnResources.BackColor = Color.MistyRose;
            btnResources.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnResources.Location = new Point(594, 344);
            btnResources.Name = "btnResources";
            btnResources.Size = new Size(353, 116);
            btnResources.TabIndex = 2;
            btnResources.Text = "View Support Resources";
            btnResources.UseVisualStyleBackColor = false;
            btnResources.Click += btnResources_Click;
            // 
            // btnTrack
            // 
            btnTrack.BackColor = Color.DarkSeaGreen;
            btnTrack.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnTrack.Location = new Point(191, 344);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(353, 116);
            btnTrack.TabIndex = 3;
            btnTrack.Text = "Track Case";
            btnTrack.UseVisualStyleBackColor = false;
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
            btnProfile.BackColor = SystemColors.Info;
            btnProfile.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(191, 197);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(353, 116);
            btnProfile.TabIndex = 5;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 50);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // VictimDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 641);
            Controls.Add(pictureBox1);
            Controls.Add(btnProfile);
            Controls.Add(btnLogout);
            Controls.Add(btnTrack);
            Controls.Add(btnResources);
            Controls.Add(btnReport);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VictimDashboard";
            Text = "VictimDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnReport;
        private Button btnResources;
        private Button btnTrack;
        private Button btnLogout;
        private Button btnProfile;
        private PictureBox pictureBox1;
    }
}