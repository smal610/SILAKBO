namespace SILAKBO.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            txtUsername = new TextBox();
            btnRegister = new Button();
            cmbGender = new ComboBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(269, 248);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F);
            txtUsername.Location = new Point(376, 240);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 33);
            txtUsername.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 14.25F);
            btnRegister.Location = new Point(269, 446);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(327, 56);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 14.25F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female" });
            cmbGender.Location = new Point(376, 374);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(220, 33);
            cmbGender.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(269, 314);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F);
            txtPassword.Location = new Point(376, 306);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 33);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(269, 382);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 6;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Monotype Corsiva", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(227, 87);
            label4.Name = "label4";
            label4.Size = new Size(432, 117);
            label4.TabIndex = 7;
            label4.Text = "SILAKBO";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 616);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(cmbGender);
            Controls.Add(btnRegister);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Button btnRegister;
        private ComboBox cmbGender;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
    }
}