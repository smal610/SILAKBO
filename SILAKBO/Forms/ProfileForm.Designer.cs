namespace SILAKBO.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            lblUsername = new Label();
            lblGender = new Label();
            lblBirthday = new Label();
            lblRole = new Label();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Century Schoolbook", 12F);
            lblUsername.Location = new Point(894, 280);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(85, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Century Schoolbook", 12F);
            lblGender.Location = new Point(894, 319);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(63, 20);
            lblGender.TabIndex = 1;
            lblGender.Text = "Gender";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.BackColor = Color.Transparent;
            lblBirthday.Font = new Font("Century Schoolbook", 12F);
            lblBirthday.Location = new Point(894, 363);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(76, 20);
            lblBirthday.TabIndex = 2;
            lblBirthday.Text = "Birthday";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Century Schoolbook", 12F);
            lblRole.Location = new Point(894, 406);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 20);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(815, 489);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 36);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label1.Location = new Point(761, 282);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 5;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label2.Location = new Point(761, 320);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 6;
            label2.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label3.Location = new Point(761, 364);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 7;
            label3.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label4.Location = new Point(761, 407);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 8;
            label4.Text = "Role:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(637, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 138);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 641);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(lblRole);
            Controls.Add(lblBirthday);
            Controls.Add(lblGender);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblGender;
        private Label lblBirthday;
        private Label lblRole;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}