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
            label1 = new Label();
            btnReport = new Button();
            btnResources = new Button();
            btnTrack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(39, 49);
            label1.Name = "label1";
            label1.Size = new Size(232, 57);
            label1.TabIndex = 0;
            label1.Text = "SILAKBO ";
            label1.Click += label1_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnReport.Location = new Point(179, 179);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(545, 100);
            btnReport.TabIndex = 1;
            btnReport.Text = "Submit Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnResources
            // 
            btnResources.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnResources.Location = new Point(179, 435);
            btnResources.Name = "btnResources";
            btnResources.Size = new Size(545, 100);
            btnResources.TabIndex = 2;
            btnResources.Text = "View Support Resources";
            btnResources.UseVisualStyleBackColor = true;
            btnResources.Click += btnResources_Click;
            // 
            // btnTrack
            // 
            btnTrack.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnTrack.Location = new Point(179, 307);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(545, 100);
            btnTrack.TabIndex = 3;
            btnTrack.Text = "Track Case";
            btnTrack.UseVisualStyleBackColor = true;
            btnTrack.Click += btnTrack_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(772, 61);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 45);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // VictimDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 616);
            Controls.Add(btnLogout);
            Controls.Add(btnTrack);
            Controls.Add(btnResources);
            Controls.Add(btnReport);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VictimDashboard";
            Text = "VictimDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReport;
        private Button btnResources;
        private Button btnTrack;
        private Button btnLogout;
    }
}