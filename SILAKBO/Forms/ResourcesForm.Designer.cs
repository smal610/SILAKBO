namespace SILAKBO.Forms
{
    partial class ResourcesForm
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
            dgvResources = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResources).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 0;
            label1.Text = "Support Resources";
            // 
            // dgvResources
            // 
            dgvResources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResources.Location = new Point(39, 153);
            dgvResources.Name = "dgvResources";
            dgvResources.Size = new Size(845, 150);
            dgvResources.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(804, 101);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ResourcesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 616);
            Controls.Add(btnRefresh);
            Controls.Add(dgvResources);
            Controls.Add(label1);
            Name = "ResourcesForm";
            Text = "ResourcesForm";
            Load += ResourcesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResources).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvResources;
        private Button btnRefresh;
    }
}