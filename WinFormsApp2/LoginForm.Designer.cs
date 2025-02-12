namespace WinFormsApp2
{
    partial class LoginForm
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
            btnLogin = new Button();
            lblLogin = new Label();
            label2 = new Label();
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            panel1 = new Panel();
            errorLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateBlue;
            btnLogin.Enabled = false;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(51, 264);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 50);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(39, 29);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(57, 20);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 122);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI", 10F);
            tbLogin.Location = new Point(39, 52);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(200, 30);
            tbLogin.TabIndex = 3;
            tbLogin.TextChanged += tbLogin_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10F);
            tbPassword.Location = new Point(39, 145);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(200, 30);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbLogin);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 210);
            panel1.TabIndex = 5;
            // 
            // errorLogin
            // 
            errorLogin.AutoSize = true;
            errorLogin.ForeColor = Color.Red;
            errorLogin.Location = new Point(76, 225);
            errorLogin.Name = "errorLogin";
            errorLogin.Size = new Size(151, 20);
            errorLogin.TabIndex = 6;
            errorLogin.Text = "Please fill every fields";
            errorLogin.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 353);
            Controls.Add(errorLogin);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblLogin;
        private Label label2;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Panel panel1;
        private Label errorLogin;
    }
}