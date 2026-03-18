namespace SILAKBO.Forms
{
    partial class AdminReportViewer
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
            dataGridView1 = new DataGridView();
            btnLoad = new Button();
            cmbStatus = new ComboBox();
            btnUpdate = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1106, 488);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(30, 29);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(85, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Reports";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "", "Investigating", "", "Resolved" });
            cmbStatus.Location = new Point(241, 591);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(673, 592);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 599);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Status:";
            // 
            // AdminReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 641);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(cmbStatus);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminReportViewer";
            Text = "AdminReportViewer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLoad;
        private ComboBox cmbStatus;
        private Button btnUpdate;
        private Label label1;
    }
}