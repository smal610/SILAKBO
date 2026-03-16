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
            label1 = new Label();
            label2 = new Label();
            txtReference = new TextBox();
            btnTrack = new Button();
            label3 = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 112);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Track Your Case";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 198);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Reference Number";
            // 
            // txtReference
            // 
            txtReference.Location = new Point(267, 190);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(184, 23);
            txtReference.TabIndex = 2;
            txtReference.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTrack
            // 
            btnTrack.Location = new Point(101, 287);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(75, 23);
            btnTrack.TabIndex = 3;
            btnTrack.Text = "Track Case";
            btnTrack.UseVisualStyleBackColor = true;
            btnTrack.Click += btnTrack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 350);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(169, 350);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(22, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "---";
            // 
            // TrackCaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 616);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(btnTrack);
            Controls.Add(txtReference);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TrackCaseForm";
            Text = "TrackCaseForm";
            Load += TrackCaseForm_Load;
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
    }
}