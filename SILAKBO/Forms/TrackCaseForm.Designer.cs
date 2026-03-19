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
            pictureBox1 = new PictureBox();
            dgvReports = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 50);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = Color.White;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(72, 144);
            dgvReports.Name = "dgvReports";
            dgvReports.Size = new Size(1035, 437);
            dgvReports.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 111);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 9;
            label1.Text = "My Reports";
            // 
            // TrackCaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 637);
            Controls.Add(label1);
            Controls.Add(dgvReports);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TrackCaseForm";
            Text = "Track Case";
            Load += TrackCaseForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dgvReports;
        private Label label1;
    }
}