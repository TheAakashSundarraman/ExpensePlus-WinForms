﻿namespace ExpensePlus
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            expensePlusLogo = new PictureBox();
            gbLogin = new GroupBox();
            chkShowPasswordLogin = new CheckBox();
            picLogo = new PictureBox();
            lnkForgotPassword = new LinkLabel();
            lnkLabel = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUsername = new Label();
            lblLogin = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)expensePlusLogo).BeginInit();
            gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // expensePlusLogo
            // 
            expensePlusLogo.Image = Properties.Resources.pexels_anna_nekrashevich_6802049;
            expensePlusLogo.Location = new Point(-36, 0);
            expensePlusLogo.Margin = new Padding(0);
            expensePlusLogo.Name = "expensePlusLogo";
            expensePlusLogo.Size = new Size(530, 806);
            expensePlusLogo.SizeMode = PictureBoxSizeMode.Zoom;
            expensePlusLogo.TabIndex = 0;
            expensePlusLogo.TabStop = false;
            // 
            // gbLogin
            // 
            gbLogin.BackColor = Color.White;
            gbLogin.Controls.Add(button1);
            gbLogin.Controls.Add(chkShowPasswordLogin);
            gbLogin.Controls.Add(picLogo);
            gbLogin.Controls.Add(lnkForgotPassword);
            gbLogin.Controls.Add(lnkLabel);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(txtPassword);
            gbLogin.Controls.Add(lblPassword);
            gbLogin.Controls.Add(txtUserName);
            gbLogin.Controls.Add(lblUsername);
            gbLogin.Controls.Add(lblLogin);
            gbLogin.Location = new Point(454, 0);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(963, 806);
            gbLogin.TabIndex = 1;
            gbLogin.TabStop = false;
            // 
            // chkShowPasswordLogin
            // 
            chkShowPasswordLogin.AutoSize = true;
            chkShowPasswordLogin.Location = new Point(618, 372);
            chkShowPasswordLogin.Name = "chkShowPasswordLogin";
            chkShowPasswordLogin.Size = new Size(134, 24);
            chkShowPasswordLogin.TabIndex = 12;
            chkShowPasswordLogin.Text = "Show password";
            chkShowPasswordLogin.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.EXPENSE;
            picLogo.Location = new Point(742, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(221, 202);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 8;
            picLogo.TabStop = false;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lnkForgotPassword.Location = new Point(506, 493);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(149, 20);
            lnkForgotPassword.TabIndex = 7;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // lnkLabel
            // 
            lnkLabel.AutoSize = true;
            lnkLabel.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lnkLabel.Location = new Point(301, 493);
            lnkLabel.Name = "lnkLabel";
            lnkLabel.Size = new Size(142, 20);
            lnkLabel.TabIndex = 6;
            lnkLabel.TabStop = true;
            lnkLabel.Text = "Create Account";
            lnkLabel.LinkClicked += lnkLabel_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Violet;
            btnLogin.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(435, 427);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(390, 369);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Please enter your password";
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtPassword.MouseHover += txtPassword_MouseHover;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(390, 346);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(386, 250);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Please enter your username";
            txtUserName.Size = new Size(210, 27);
            txtUserName.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(386, 227);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(93, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.Violet;
            lblLogin.Location = new Point(360, 63);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(237, 91);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // panel1
            // 
            panel1.Controls.Add(expensePlusLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 806);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(914, 12);
            button1.Name = "button1";
            button1.Size = new Size(43, 29);
            button1.TabIndex = 13;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(gbLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += Login_MouseDown;
            MouseMove += Login_MouseMove;
            MouseUp += Login_MouseUp;
            ((System.ComponentModel.ISupportInitialize)expensePlusLogo).EndInit();
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox expensePlusLogo;
        private GroupBox gbLogin;
        private Label lblLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUsername;
        private LinkLabel lnkLabel;
        private Button btnLogin;
        private LinkLabel lnkForgotPassword;
        private PictureBox picLogo;
        private Panel panel1;
        private CheckBox chkShowPasswordLogin;
        private Button button1;
    }
}