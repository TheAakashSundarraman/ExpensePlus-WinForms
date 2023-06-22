namespace ExpensePlus
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            lblLogin = new Label();
            pnlForgotPassword = new Panel();
            pnlResetPasswordarea = new Panel();
            chkShowPasswordReEnterPASS = new CheckBox();
            chkShowPasswordEnterPASS = new CheckBox();
            lblSecretKeyQuestionHeader = new Label();
            lblSecretKeyQuestion = new Label();
            txtReEnterNewPassword = new TextBox();
            lblSecretKeyAnswerHeader = new Label();
            lblReenterNewPasswordHeader = new Label();
            txtSecretKeyAnswer = new TextBox();
            txtEnterNewPassword = new TextBox();
            btnUpdatePassword = new Button();
            lblNewPasswordHeader = new Label();
            lblRequiredField = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnFetchData = new Button();
            lblUsername = new Label();
            txtUserName = new TextBox();
            button1 = new Button();
            pnlForgotPassword.SuspendLayout();
            pnlResetPasswordarea.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.Violet;
            lblLogin.Location = new Point(549, 38);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(367, 52);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Forgot Password";
            // 
            // pnlForgotPassword
            // 
            pnlForgotPassword.BackColor = Color.White;
            pnlForgotPassword.Controls.Add(pnlResetPasswordarea);
            pnlForgotPassword.Controls.Add(lblRequiredField);
            pnlForgotPassword.Controls.Add(panel1);
            pnlForgotPassword.Controls.Add(btnFetchData);
            pnlForgotPassword.Controls.Add(lblUsername);
            pnlForgotPassword.Controls.Add(txtUserName);
            pnlForgotPassword.Location = new Point(63, 110);
            pnlForgotPassword.Name = "pnlForgotPassword";
            pnlForgotPassword.Size = new Size(1285, 649);
            pnlForgotPassword.TabIndex = 2;
            // 
            // pnlResetPasswordarea
            // 
            pnlResetPasswordarea.Controls.Add(chkShowPasswordReEnterPASS);
            pnlResetPasswordarea.Controls.Add(chkShowPasswordEnterPASS);
            pnlResetPasswordarea.Controls.Add(lblSecretKeyQuestionHeader);
            pnlResetPasswordarea.Controls.Add(lblSecretKeyQuestion);
            pnlResetPasswordarea.Controls.Add(txtReEnterNewPassword);
            pnlResetPasswordarea.Controls.Add(lblSecretKeyAnswerHeader);
            pnlResetPasswordarea.Controls.Add(lblReenterNewPasswordHeader);
            pnlResetPasswordarea.Controls.Add(txtSecretKeyAnswer);
            pnlResetPasswordarea.Controls.Add(txtEnterNewPassword);
            pnlResetPasswordarea.Controls.Add(btnUpdatePassword);
            pnlResetPasswordarea.Controls.Add(lblNewPasswordHeader);
            pnlResetPasswordarea.Location = new Point(638, 164);
            pnlResetPasswordarea.Name = "pnlResetPasswordarea";
            pnlResetPasswordarea.Size = new Size(644, 485);
            pnlResetPasswordarea.TabIndex = 17;
            // 
            // chkShowPasswordReEnterPASS
            // 
            chkShowPasswordReEnterPASS.AutoSize = true;
            chkShowPasswordReEnterPASS.Location = new Point(499, 301);
            chkShowPasswordReEnterPASS.Name = "chkShowPasswordReEnterPASS";
            chkShowPasswordReEnterPASS.Size = new Size(134, 24);
            chkShowPasswordReEnterPASS.TabIndex = 18;
            chkShowPasswordReEnterPASS.Text = "Show password";
            chkShowPasswordReEnterPASS.UseVisualStyleBackColor = true;
            // 
            // chkShowPasswordEnterPASS
            // 
            chkShowPasswordEnterPASS.AutoSize = true;
            chkShowPasswordEnterPASS.Location = new Point(183, 301);
            chkShowPasswordEnterPASS.Name = "chkShowPasswordEnterPASS";
            chkShowPasswordEnterPASS.Size = new Size(134, 24);
            chkShowPasswordEnterPASS.TabIndex = 17;
            chkShowPasswordEnterPASS.Text = "Show password";
            chkShowPasswordEnterPASS.UseVisualStyleBackColor = true;
            // 
            // lblSecretKeyQuestionHeader
            // 
            lblSecretKeyQuestionHeader.AutoSize = true;
            lblSecretKeyQuestionHeader.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecretKeyQuestionHeader.Location = new Point(15, 20);
            lblSecretKeyQuestionHeader.Name = "lblSecretKeyQuestionHeader";
            lblSecretKeyQuestionHeader.Size = new Size(187, 20);
            lblSecretKeyQuestionHeader.TabIndex = 7;
            lblSecretKeyQuestionHeader.Text = "Secret Key Question:";
            // 
            // lblSecretKeyQuestion
            // 
            lblSecretKeyQuestion.AutoSize = true;
            lblSecretKeyQuestion.Location = new Point(23, 53);
            lblSecretKeyQuestion.Name = "lblSecretKeyQuestion";
            lblSecretKeyQuestion.Size = new Size(50, 20);
            lblSecretKeyQuestion.TabIndex = 16;
            lblSecretKeyQuestion.Text = "label1";
            // 
            // txtReEnterNewPassword
            // 
            txtReEnterNewPassword.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtReEnterNewPassword.Location = new Point(342, 298);
            txtReEnterNewPassword.Multiline = true;
            txtReEnterNewPassword.Name = "txtReEnterNewPassword";
            txtReEnterNewPassword.PlaceholderText = "John#123";
            txtReEnterNewPassword.Size = new Size(151, 29);
            txtReEnterNewPassword.TabIndex = 14;
            txtReEnterNewPassword.MouseHover += txtReEnterNewPassword_MouseHover;
            // 
            // lblSecretKeyAnswerHeader
            // 
            lblSecretKeyAnswerHeader.AutoSize = true;
            lblSecretKeyAnswerHeader.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecretKeyAnswerHeader.Location = new Point(15, 87);
            lblSecretKeyAnswerHeader.Name = "lblSecretKeyAnswerHeader";
            lblSecretKeyAnswerHeader.Size = new Size(171, 20);
            lblSecretKeyAnswerHeader.TabIndex = 8;
            lblSecretKeyAnswerHeader.Text = "Secret Key Answer";
            // 
            // lblReenterNewPasswordHeader
            // 
            lblReenterNewPasswordHeader.AutoSize = true;
            lblReenterNewPasswordHeader.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblReenterNewPasswordHeader.Location = new Point(342, 248);
            lblReenterNewPasswordHeader.Name = "lblReenterNewPasswordHeader";
            lblReenterNewPasswordHeader.Size = new Size(209, 20);
            lblReenterNewPasswordHeader.TabIndex = 13;
            lblReenterNewPasswordHeader.Text = "Re-enter new password";
            // 
            // txtSecretKeyAnswer
            // 
            txtSecretKeyAnswer.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecretKeyAnswer.Location = new Point(34, 134);
            txtSecretKeyAnswer.Multiline = true;
            txtSecretKeyAnswer.Name = "txtSecretKeyAnswer";
            txtSecretKeyAnswer.PlaceholderText = "Please enter the answer to your secret question";
            txtSecretKeyAnswer.Size = new Size(460, 80);
            txtSecretKeyAnswer.TabIndex = 9;
            // 
            // txtEnterNewPassword
            // 
            txtEnterNewPassword.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnterNewPassword.Location = new Point(34, 298);
            txtEnterNewPassword.Multiline = true;
            txtEnterNewPassword.Name = "txtEnterNewPassword";
            txtEnterNewPassword.PlaceholderText = "John#123";
            txtEnterNewPassword.Size = new Size(143, 29);
            txtEnterNewPassword.TabIndex = 12;
            txtEnterNewPassword.MouseHover += txtEnterNewPassword_MouseHover;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.HotPink;
            btnUpdatePassword.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdatePassword.ForeColor = Color.White;
            btnUpdatePassword.Location = new Point(178, 374);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(156, 55);
            btnUpdatePassword.TabIndex = 10;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // lblNewPasswordHeader
            // 
            lblNewPasswordHeader.AutoSize = true;
            lblNewPasswordHeader.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewPasswordHeader.Location = new Point(34, 248);
            lblNewPasswordHeader.Name = "lblNewPasswordHeader";
            lblNewPasswordHeader.Size = new Size(177, 20);
            lblNewPasswordHeader.TabIndex = 11;
            lblNewPasswordHeader.Text = "Enter new password";
            // 
            // lblRequiredField
            // 
            lblRequiredField.AutoSize = true;
            lblRequiredField.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequiredField.ForeColor = Color.DeepPink;
            lblRequiredField.Location = new Point(1181, 125);
            lblRequiredField.Name = "lblRequiredField";
            lblRequiredField.Size = new Size(15, 15);
            lblRequiredField.TabIndex = 15;
            lblRequiredField.Text = "*";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 649);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.EXPENSE;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 649);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnFetchData
            // 
            btnFetchData.BackColor = Color.HotPink;
            btnFetchData.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFetchData.ForeColor = Color.White;
            btnFetchData.Location = new Point(1076, 117);
            btnFetchData.Name = "btnFetchData";
            btnFetchData.Size = new Size(99, 31);
            btnFetchData.TabIndex = 5;
            btnFetchData.Text = "Fetch Data";
            btnFetchData.UseVisualStyleBackColor = false;
            btnFetchData.Click += btnFetchData_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(653, 72);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(93, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(653, 107);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Please enter your username: mandatory";
            txtUserName.Size = new Size(417, 41);
            txtUserName.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1300, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(button1);
            Controls.Add(pnlForgotPassword);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            MouseDown += ForgotPassword_MouseDown;
            MouseMove += ForgotPassword_MouseMove;
            MouseUp += ForgotPassword_MouseUp;
            pnlForgotPassword.ResumeLayout(false);
            pnlForgotPassword.PerformLayout();
            pnlResetPasswordarea.ResumeLayout(false);
            pnlResetPasswordarea.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Panel pnlForgotPassword;
        private TextBox txtUserName;
        private Label lblUsername;
        private Button btnFetchData;
        private Label lblSecretKeyAnswerHeader;
        private Label lblSecretKeyQuestionHeader;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtSecretKeyAnswer;
        private TextBox txtEnterNewPassword;
        private Label lblNewPasswordHeader;
        private Button btnUpdatePassword;
        private TextBox txtReEnterNewPassword;
        private Label lblReenterNewPasswordHeader;
        private Label lblRequiredField;
        private Label lblSecretKeyQuestion;
        private Panel pnlResetPasswordarea;
        private CheckBox chkShowPasswordReEnterPASS;
        private CheckBox chkShowPasswordEnterPASS;
        private Button button1;
    }
}