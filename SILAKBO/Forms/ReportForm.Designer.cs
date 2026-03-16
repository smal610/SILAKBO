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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 99);
            label1.Name = "label1";
            label1.Size = new Size(491, 50);
            label1.TabIndex = 0;
            label1.Text = "Submit Harassment Report";
            // 
            // cmbIncident
            // 
            cmbIncident.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbIncident.FormattingEnabled = true;
            cmbIncident.Items.AddRange(new object[] { "Verbal Harassment", "Physical Harassment", "Online Harassment", "Stalking", "Other" });
            cmbIncident.Location = new Point(345, 173);
            cmbIncident.Name = "cmbIncident";
            cmbIncident.Size = new Size(468, 29);
            cmbIncident.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(345, 229);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // txtDescription
            // 
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
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(345, 413);
            label3.Name = "label3";
            label3.Size = new Size(162, 21);
            label3.TabIndex = 4;
            label3.Text = "Evidence (Optional)";
            label3.Click += label3_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            txtEvidence.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEvidence.Location = new Point(345, 444);
            txtEvidence.Name = "txtEvidence";
            txtEvidence.Size = new Size(344, 29);
            txtEvidence.TabIndex = 8;
            txtEvidence.Click += txtEvidence_Click;
            txtEvidence.TextChanged += txtEvidence_TextChanged;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 641);
            Controls.Add(txtEvidence);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(cmbIncident);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ReportForm";
            Text = "ReportForm";
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
    }
}