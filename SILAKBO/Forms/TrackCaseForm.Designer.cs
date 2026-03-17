namespace SILAKBO.Forms
{
    partial class TrackCaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackCaseForm));
            label1 = new Label();
            label2 = new Label();
            txtReference = new TextBox();
            btnTrack = new Button();
            label3 = new Label();
            lblStatus = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(579, 151);
            label1.Name = "label1";
            label1.Size = new Size(295, 37);
            label1.TabIndex = 0;
            label1.Text = "Track Your Case";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label2.Location = new Point(579, 223);
            label2.Name = "label2";
            label2.Size = new Size(219, 19);
            label2.TabIndex = 1;
            label2.Text = "Enter Reference Number:";
            // 
            // txtReference
            // 
            txtReference.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReference.Location = new Point(579, 262);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(532, 27);
            txtReference.TabIndex = 2;
            txtReference.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTrack
            // 
            btnTrack.BackColor = Color.Indigo;
            btnTrack.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrack.ForeColor = Color.White;
            btnTrack.Location = new Point(578, 321);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(532, 52);
            btnTrack.TabIndex = 3;
            btnTrack.Text = "Track Case";
            btnTrack.UseVisualStyleBackColor = false;
            btnTrack.Click += btnTrack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label3.Location = new Point(579, 401);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Century Schoolbook", 12F);
            lblStatus.Location = new Point(657, 401);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(24, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "---";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(906, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 50);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TrackCaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 637);
            Controls.Add(pictureBox1);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(btnTrack);
            Controls.Add(txtReference);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TrackCaseForm";
            Text = "Track Case";
            Load += TrackCaseForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtReference;
        private Button btnTrack;
        private Label label3;
        private Label lblStatus;
        private PictureBox pictureBox1;
    }
}