namespace ExpensePlus
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            tbProfiles = new TabControl();
            profileTab = new TabPage();
            chkGender = new CheckedListBox();
            Clear = new Button();
            btnSave = new Button();
            lblGender = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            dtDateofBirth = new DateTimePicker();
            lblDateofBirth = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            forgotPasswordTab = new TabPage();
            txtSecretKeyAnswer = new TextBox();
            txtSecretKeyQuestion = new TextBox();
            lblSecretKeyAnswer = new Label();
            lblSecretKeyQuestion = new Label();
            chkReenterNewPwd = new CheckBox();
            chkShowNewPwd = new CheckBox();
            chkShowPassword = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            lblRequiredNewPassword = new Label();
            btnReset = new Button();
            btnUpdatePwd = new Button();
            txtReenternewpwd = new TextBox();
            lblRenterPwd = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtCurentPassword = new TextBox();
            lblCurrentPassword = new Label();
            pnlLeftNavigation = new Panel();
            tbProfiles.SuspendLayout();
            profileTab.SuspendLayout();
            forgotPasswordTab.SuspendLayout();
            SuspendLayout();
            // 
            // tbProfiles
            // 
            tbProfiles.Controls.Add(profileTab);
            tbProfiles.Controls.Add(forgotPasswordTab);
            tbProfiles.Location = new Point(283, 24);
            tbProfiles.Name = "tbProfiles";
            tbProfiles.SelectedIndex = 0;
            tbProfiles.Size = new Size(1101, 759);
            tbProfiles.TabIndex = 1;
            // 
            // profileTab
            // 
            profileTab.Controls.Add(chkGender);
            profileTab.Controls.Add(Clear);
            profileTab.Controls.Add(btnSave);
            profileTab.Controls.Add(lblGender);
            profileTab.Controls.Add(txtPhone);
            profileTab.Controls.Add(lblPhone);
            profileTab.Controls.Add(dtDateofBirth);
            profileTab.Controls.Add(lblDateofBirth);
            profileTab.Controls.Add(txtEmail);
            profileTab.Controls.Add(lblEmail);
            profileTab.Controls.Add(txtLastName);
            profileTab.Controls.Add(lblLastName);
            profileTab.Controls.Add(txtFirstName);
            profileTab.Controls.Add(lblFirstName);
            profileTab.Location = new Point(4, 30);
            profileTab.Name = "profileTab";
            profileTab.Padding = new Padding(3);
            profileTab.Size = new Size(1093, 725);
            profileTab.TabIndex = 0;
            profileTab.Text = "Profile";
            profileTab.UseVisualStyleBackColor = true;
            // 
            // chkGender
            // 
            chkGender.FormattingEnabled = true;
            chkGender.Location = new Point(395, 313);
            chkGender.Name = "chkGender";
            chkGender.Size = new Size(150, 114);
            chkGender.TabIndex = 14;
            chkGender.ItemCheck += chkGender_ItemCheck;
            // 
            // Clear
            // 
            Clear.Location = new Point(467, 451);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 13;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(263, 451);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Update Profile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(244, 331);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 20);
            lblGender.TabIndex = 10;
            lblGender.Text = "Gender:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(395, 270);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(367, 27);
            txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(244, 273);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 20);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // dtDateofBirth
            // 
            dtDateofBirth.CustomFormat = "dd/MMM/yyyy";
            dtDateofBirth.Format = DateTimePickerFormat.Custom;
            dtDateofBirth.Location = new Point(395, 214);
            dtDateofBirth.Name = "dtDateofBirth";
            dtDateofBirth.Size = new Size(367, 27);
            dtDateofBirth.TabIndex = 7;
            // 
            // lblDateofBirth
            // 
            lblDateofBirth.AutoSize = true;
            lblDateofBirth.Location = new Point(244, 221);
            lblDateofBirth.Name = "lblDateofBirth";
            lblDateofBirth.Size = new Size(119, 20);
            lblDateofBirth.TabIndex = 6;
            lblDateofBirth.Text = "Date of birth:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(395, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(367, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(244, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(394, 117);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(367, 27);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(243, 120);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(394, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(367, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(243, 73);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(105, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // forgotPasswordTab
            // 
            forgotPasswordTab.Controls.Add(txtSecretKeyAnswer);
            forgotPasswordTab.Controls.Add(txtSecretKeyQuestion);
            forgotPasswordTab.Controls.Add(lblSecretKeyAnswer);
            forgotPasswordTab.Controls.Add(lblSecretKeyQuestion);
            forgotPasswordTab.Controls.Add(chkReenterNewPwd);
            forgotPasswordTab.Controls.Add(chkShowNewPwd);
            forgotPasswordTab.Controls.Add(chkShowPassword);
            forgotPasswordTab.Controls.Add(label2);
            forgotPasswordTab.Controls.Add(label1);
            forgotPasswordTab.Controls.Add(lblRequiredNewPassword);
            forgotPasswordTab.Controls.Add(btnReset);
            forgotPasswordTab.Controls.Add(btnUpdatePwd);
            forgotPasswordTab.Controls.Add(txtReenternewpwd);
            forgotPasswordTab.Controls.Add(lblRenterPwd);
            forgotPasswordTab.Controls.Add(txtNewPassword);
            forgotPasswordTab.Controls.Add(lblNewPassword);
            forgotPasswordTab.Controls.Add(txtCurentPassword);
            forgotPasswordTab.Controls.Add(lblCurrentPassword);
            forgotPasswordTab.Location = new Point(4, 30);
            forgotPasswordTab.Name = "forgotPasswordTab";
            forgotPasswordTab.Padding = new Padding(3);
            forgotPasswordTab.Size = new Size(1093, 725);
            forgotPasswordTab.TabIndex = 1;
            forgotPasswordTab.Text = "Forgot Password";
            forgotPasswordTab.UseVisualStyleBackColor = true;
            // 
            // txtSecretKeyAnswer
            // 
            txtSecretKeyAnswer.Location = new Point(448, 282);
            txtSecretKeyAnswer.Multiline = true;
            txtSecretKeyAnswer.Name = "txtSecretKeyAnswer";
            txtSecretKeyAnswer.Size = new Size(261, 107);
            txtSecretKeyAnswer.TabIndex = 17;
            // 
            // txtSecretKeyQuestion
            // 
            txtSecretKeyQuestion.Location = new Point(448, 141);
            txtSecretKeyQuestion.Multiline = true;
            txtSecretKeyQuestion.Name = "txtSecretKeyQuestion";
            txtSecretKeyQuestion.Size = new Size(261, 107);
            txtSecretKeyQuestion.TabIndex = 16;
            // 
            // lblSecretKeyAnswer
            // 
            lblSecretKeyAnswer.AutoSize = true;
            lblSecretKeyAnswer.Location = new Point(226, 315);
            lblSecretKeyAnswer.Name = "lblSecretKeyAnswer";
            lblSecretKeyAnswer.Size = new Size(175, 20);
            lblSecretKeyAnswer.TabIndex = 15;
            lblSecretKeyAnswer.Text = "Secret Key Answer:";
            // 
            // lblSecretKeyQuestion
            // 
            lblSecretKeyQuestion.AutoSize = true;
            lblSecretKeyQuestion.Location = new Point(214, 141);
            lblSecretKeyQuestion.Name = "lblSecretKeyQuestion";
            lblSecretKeyQuestion.Size = new Size(187, 20);
            lblSecretKeyQuestion.TabIndex = 14;
            lblSecretKeyQuestion.Text = "Secret Key Question:";
            // 
            // chkReenterNewPwd
            // 
            chkReenterNewPwd.AutoSize = true;
            chkReenterNewPwd.Location = new Point(740, 464);
            chkReenterNewPwd.Name = "chkReenterNewPwd";
            chkReenterNewPwd.Size = new Size(160, 24);
            chkReenterNewPwd.TabIndex = 13;
            chkReenterNewPwd.Text = "Show password";
            chkReenterNewPwd.UseVisualStyleBackColor = true;
            chkReenterNewPwd.MouseHover += chkReenterNewPwd_MouseHover;
            // 
            // chkShowNewPwd
            // 
            chkShowNewPwd.AutoSize = true;
            chkShowNewPwd.Location = new Point(740, 417);
            chkShowNewPwd.Name = "chkShowNewPwd";
            chkShowNewPwd.Size = new Size(160, 24);
            chkShowNewPwd.TabIndex = 12;
            chkShowNewPwd.Text = "Show password";
            chkShowNewPwd.UseVisualStyleBackColor = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(740, 85);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(160, 24);
            chkShowPassword.TabIndex = 11;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(715, 89);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 10;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(715, 465);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 9;
            label1.Text = "*";
            // 
            // lblRequiredNewPassword
            // 
            lblRequiredNewPassword.AutoSize = true;
            lblRequiredNewPassword.ForeColor = Color.Red;
            lblRequiredNewPassword.Location = new Point(715, 421);
            lblRequiredNewPassword.Name = "lblRequiredNewPassword";
            lblRequiredNewPassword.Size = new Size(19, 20);
            lblRequiredNewPassword.TabIndex = 8;
            lblRequiredNewPassword.Text = "*";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(486, 543);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(163, 29);
            btnReset.TabIndex = 7;
            btnReset.Text = "Clear";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePwd
            // 
            btnUpdatePwd.Location = new Point(269, 543);
            btnUpdatePwd.Name = "btnUpdatePwd";
            btnUpdatePwd.Size = new Size(163, 29);
            btnUpdatePwd.TabIndex = 6;
            btnUpdatePwd.Text = "Update Password";
            btnUpdatePwd.UseVisualStyleBackColor = true;
            btnUpdatePwd.Click += btnUpdatePwd_Click;
            // 
            // txtReenternewpwd
            // 
            txtReenternewpwd.Location = new Point(448, 465);
            txtReenternewpwd.Name = "txtReenternewpwd";
            txtReenternewpwd.PasswordChar = '*';
            txtReenternewpwd.PlaceholderText = "Mandatory Field";
            txtReenternewpwd.Size = new Size(261, 27);
            txtReenternewpwd.TabIndex = 5;
            // 
            // lblRenterPwd
            // 
            lblRenterPwd.AutoSize = true;
            lblRenterPwd.Location = new Point(183, 468);
            lblRenterPwd.Name = "lblRenterPwd";
            lblRenterPwd.Size = new Size(218, 20);
            lblRenterPwd.TabIndex = 4;
            lblRenterPwd.Text = "Re-enter New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(448, 414);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.PlaceholderText = "Mandatory Field";
            txtNewPassword.Size = new Size(261, 27);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.MouseHover += txtNewPassword_MouseHover;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(266, 410);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(135, 20);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password:";
            // 
            // txtCurentPassword
            // 
            txtCurentPassword.Location = new Point(448, 82);
            txtCurentPassword.Name = "txtCurentPassword";
            txtCurentPassword.PasswordChar = '*';
            txtCurentPassword.PlaceholderText = "Mandatory Field";
            txtCurentPassword.Size = new Size(261, 27);
            txtCurentPassword.TabIndex = 1;
            txtCurentPassword.MouseHover += txtCurentPassword_MouseHover;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(214, 82);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(163, 20);
            lblCurrentPassword.TabIndex = 0;
            lblCurrentPassword.Text = "Current Password:";
            // 
            // pnlLeftNavigation
            // 
            pnlLeftNavigation.BackColor = Color.WhiteSmoke;
            pnlLeftNavigation.Dock = DockStyle.Left;
            pnlLeftNavigation.Location = new Point(0, 0);
            pnlLeftNavigation.Name = "pnlLeftNavigation";
            pnlLeftNavigation.Size = new Size(250, 806);
            pnlLeftNavigation.TabIndex = 2;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(pnlLeftNavigation);
            Controls.Add(tbProfiles);
            Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            FormClosing += Profile_FormClosing;
            FormClosed += Profile_FormClosed;
            Load += Profile_Load;
            MouseDown += Profile_MouseDown;
            MouseMove += Profile_MouseMove;
            MouseUp += Profile_MouseUp;
            tbProfiles.ResumeLayout(false);
            profileTab.ResumeLayout(false);
            profileTab.PerformLayout();
            forgotPasswordTab.ResumeLayout(false);
            forgotPasswordTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tbProfiles;
        private TabPage profileTab;
        private TabPage forgotPasswordTab;
        private Label lblDateofBirth;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private DateTimePicker dtDateofBirth;
        private Button btnSave;
        private Label lblGender;
        private TextBox txtPhone;
        private Label lblPhone;
        private Button Clear;
        private TextBox txtReenternewpwd;
        private Label lblRenterPwd;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtCurentPassword;
        private Label lblCurrentPassword;
        private Button btnUpdatePwd;
        private Button btnReset;
        private Label lblRequiredNewPassword;
        private Label label1;
        private Label label2;
        private CheckBox chkShowPassword;
        private CheckBox chkReenterNewPwd;
        private CheckBox chkShowNewPwd;
        private CheckedListBox chkGender;
        private Label lblSecretKeyQuestion;
        private TextBox txtSecretKeyQuestion;
        private Label lblSecretKeyAnswer;
        private TextBox txtSecretKeyAnswer;
        private Panel pnlLeftNavigation;
    }
}