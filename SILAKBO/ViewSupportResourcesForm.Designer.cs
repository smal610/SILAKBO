namespace SILAKBO
{
    partial class ViewSupportResourcesForm
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 163);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Support Resources";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Philippine Commission on Women", "DSWD Violence Against Women Desk", "PNP Women and Children Protection Desk", "NBI Violence Against Women Desk", "National Center for Mental Health Hotline", "1553" });
            listBox1.Location = new Point(237, 217);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(964, 394);
            listBox1.TabIndex = 1;
            // 
            // ViewSupportResourcesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 839);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "ViewSupportResourcesForm";
            Text = "ViewSupportResourcesForm";
            Load += ViewSupportResourcesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
    }
}