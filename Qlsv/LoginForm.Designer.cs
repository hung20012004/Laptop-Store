namespace Qlsv
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            lbUsername = new Label();
            lbPassword = new Label();
            lbRole = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            cbRole = new ComboBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(231, 264);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 44);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(50, 80);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(140, 28);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Tên đăng nhập";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(50, 140);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(94, 28);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Mật khẩu";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(50, 200);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(69, 28);
            lbRole.TabIndex = 3;
            lbRole.Text = "Vai trò";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(231, 80);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(365, 34);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(231, 140);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(365, 34);
            tbPassword.TabIndex = 5;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Sinh viên", "Giảng viên" });
            cbRole.Location = new Point(231, 200);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(182, 36);
            cbRole.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 379);
            Controls.Add(cbRole);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbRole);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lbUsername;
        private Label lbPassword;
        private Label lbRole;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private ComboBox cbRole;
    }
}