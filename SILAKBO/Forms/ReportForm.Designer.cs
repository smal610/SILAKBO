namespace SILAKBO.Forms
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            label1 = new Label();
            cmbIncident = new ComboBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            btnBrowse = new Button();
            btnSubmit = new Button();
            txtEvidence = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 114);
            label1.Name = "label1";
            label1.Size = new Size(354, 30);
            label1.TabIndex = 0;
            label1.Text = "Submit Harassment Report";
            // 
            // cmbIncident
            // 
            cmbIncident.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbIncident.FormattingEnabled = true;
            cmbIncident.Items.AddRange(new object[] { "Verbal Harassment", "Physical Harassment", "Online Harassment", "Stalking", "Other" });
            cmbIncident.Location = new Point(345, 173);
            cmbIncident.Name = "cmbIncident";
            cmbIncident.Size = new Size(468, 28);
            cmbIncident.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label2.Location = new Point(345, 229);
            label2.Name = "label2";
            label2.Size = new Size(107, 19);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(345, 259);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(468, 121);
            txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label3.Location = new Point(345, 413);
            label3.Name = "label3";
            label3.Size = new Size(177, 19);
            label3.TabIndex = 4;
            label3.Text = "Evidence (Optional)";
            label3.Click += label3_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(695, 444);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(118, 29);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(345, 490);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(468, 51);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtEvidence
            // 
            txtEvidence.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEvidence.Location = new Point(345, 444);
            txtEvidence.Name = "txtEvidence";
            txtEvidence.Size = new Size(344, 27);
            txtEvidence.TabIndex = 8;
            txtEvidence.Click += txtEvidence_Click;
            txtEvidence.TextChanged += txtEvidence_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 641);
            Controls.Add(pictureBox1);
            Controls.Add(txtEvidence);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(cmbIncident);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbIncident;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private Button btnBrowse;
        private Button btnSubmit;
        private TextBox txtEvidence;
        private PictureBox pictureBox1;
    }
}