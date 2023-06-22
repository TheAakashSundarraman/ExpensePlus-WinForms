namespace ExpensePlus
{
    partial class CreateAccount
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            lblUserName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblDateOfBirth = new Label();
            chkLstBoxGender = new CheckedListBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtDOB = new DateTimePicker();
            lblGender = new Label();
            genderBindingSource = new BindingSource(components);
            btnAddUser = new Button();
            txtPassword = new TextBox();
            lblSecretKeyQuestion = new Label();
            txtSecretKeyQuestion = new TextBox();
            lblSecretKeyAnswer = new Label();
            txtSecretKeyAnswer = new TextBox();
            pnlCreateAccountBack = new Panel();
            chkShowPasswordCreate = new CheckBox();
            pnlsideCreateAccount = new Panel();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            btnBackToLoginCreateAccountOne = new Button();
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).BeginInit();
            pnlCreateAccountBack.SuspendLayout();
            pnlsideCreateAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(641, 48);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(101, 20);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(641, 144);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(641, 248);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(61, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(641, 331);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(641, 434);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(1071, 225);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(115, 20);
            lblDateOfBirth.TabIndex = 8;
            lblDateOfBirth.Text = "Date of birth";
            // 
            // chkLstBoxGender
            // 
            chkLstBoxGender.FormattingEnabled = true;
            chkLstBoxGender.Location = new Point(901, 261);
            chkLstBoxGender.Name = "chkLstBoxGender";
            chkLstBoxGender.Size = new Size(150, 114);
            chkLstBoxGender.TabIndex = 8;
            chkLstBoxGender.ThreeDCheckBoxes = true;
            chkLstBoxGender.ItemCheck += chkLstBoxGender_ItemCheck;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(641, 84);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(179, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(641, 180);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(641, 372);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(641, 284);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(179, 27);
            txtPhone.TabIndex = 3;
            // 
            // dtDOB
            // 
            dtDOB.CalendarFont = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtDOB.CalendarForeColor = Color.White;
            dtDOB.CalendarMonthBackground = Color.Violet;
            dtDOB.CalendarTitleBackColor = Color.Violet;
            dtDOB.CalendarTitleForeColor = Color.White;
            dtDOB.CustomFormat = "dd/MMM/yyyy";
            dtDOB.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtDOB.Location = new Point(1071, 261);
            dtDOB.Name = "dtDOB";
            dtDOB.Size = new Size(250, 27);
            dtDOB.TabIndex = 9;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(901, 225);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(70, 20);
            lblGender.TabIndex = 16;
            lblGender.Text = "Gender";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Violet;
            btnAddUser.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(1071, 499);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(221, 81);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Create";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(641, 469);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(194, 27);
            txtPassword.TabIndex = 5;
            txtPassword.MouseHover += txtPassword_MouseHover;
            // 
            // lblSecretKeyQuestion
            // 
            lblSecretKeyQuestion.AutoSize = true;
            lblSecretKeyQuestion.Location = new Point(901, 52);
            lblSecretKeyQuestion.Name = "lblSecretKeyQuestion";
            lblSecretKeyQuestion.Size = new Size(141, 20);
            lblSecretKeyQuestion.TabIndex = 19;
            lblSecretKeyQuestion.Text = "Secret Key Question";
            // 
            // txtSecretKeyQuestion
            // 
            txtSecretKeyQuestion.Location = new Point(901, 84);
            txtSecretKeyQuestion.Multiline = true;
            txtSecretKeyQuestion.Name = "txtSecretKeyQuestion";
            txtSecretKeyQuestion.Size = new Size(189, 111);
            txtSecretKeyQuestion.TabIndex = 6;
            // 
            // lblSecretKeyAnswer
            // 
            lblSecretKeyAnswer.AutoSize = true;
            lblSecretKeyAnswer.Location = new Point(1132, 52);
            lblSecretKeyAnswer.Name = "lblSecretKeyAnswer";
            lblSecretKeyAnswer.Size = new Size(130, 20);
            lblSecretKeyAnswer.TabIndex = 21;
            lblSecretKeyAnswer.Text = "Secret Key Answer";
            // 
            // txtSecretKeyAnswer
            // 
            txtSecretKeyAnswer.Location = new Point(1132, 84);
            txtSecretKeyAnswer.Multiline = true;
            txtSecretKeyAnswer.Name = "txtSecretKeyAnswer";
            txtSecretKeyAnswer.Size = new Size(189, 111);
            txtSecretKeyAnswer.TabIndex = 7;
            // 
            // pnlCreateAccountBack
            // 
            pnlCreateAccountBack.BackColor = Color.WhiteSmoke;
            pnlCreateAccountBack.Controls.Add(chkShowPasswordCreate);
            pnlCreateAccountBack.Controls.Add(dtDOB);
            pnlCreateAccountBack.Controls.Add(lblGender);
            pnlCreateAccountBack.Controls.Add(chkLstBoxGender);
            pnlCreateAccountBack.Controls.Add(txtEmail);
            pnlCreateAccountBack.Controls.Add(lblUserName);
            pnlCreateAccountBack.Controls.Add(txtLastName);
            pnlCreateAccountBack.Controls.Add(lblEmail);
            pnlCreateAccountBack.Controls.Add(lblLastName);
            pnlCreateAccountBack.Controls.Add(txtPassword);
            pnlCreateAccountBack.Controls.Add(txtPhone);
            pnlCreateAccountBack.Controls.Add(btnAddUser);
            pnlCreateAccountBack.Controls.Add(txtFirstName);
            pnlCreateAccountBack.Controls.Add(lblPassword);
            pnlCreateAccountBack.Controls.Add(lblPhone);
            pnlCreateAccountBack.Controls.Add(txtSecretKeyAnswer);
            pnlCreateAccountBack.Controls.Add(lblDateOfBirth);
            pnlCreateAccountBack.Controls.Add(lblSecretKeyAnswer);
            pnlCreateAccountBack.Controls.Add(lblSecretKeyQuestion);
            pnlCreateAccountBack.Controls.Add(txtSecretKeyQuestion);
            pnlCreateAccountBack.Controls.Add(pnlsideCreateAccount);
            pnlCreateAccountBack.Location = new Point(42, 124);
            pnlCreateAccountBack.Name = "pnlCreateAccountBack";
            pnlCreateAccountBack.Size = new Size(1337, 627);
            pnlCreateAccountBack.TabIndex = 23;
            // 
            // chkShowPasswordCreate
            // 
            chkShowPasswordCreate.AutoSize = true;
            chkShowPasswordCreate.Location = new Point(854, 471);
            chkShowPasswordCreate.Name = "chkShowPasswordCreate";
            chkShowPasswordCreate.Size = new Size(134, 24);
            chkShowPasswordCreate.TabIndex = 23;
            chkShowPasswordCreate.Text = "Show password";
            chkShowPasswordCreate.UseVisualStyleBackColor = true;
            // 
            // pnlsideCreateAccount
            // 
            pnlsideCreateAccount.BackColor = Color.White;
            pnlsideCreateAccount.Controls.Add(pictureBox1);
            pnlsideCreateAccount.Dock = DockStyle.Left;
            pnlsideCreateAccount.Location = new Point(0, 0);
            pnlsideCreateAccount.Name = "pnlsideCreateAccount";
            pnlsideCreateAccount.Size = new Size(500, 627);
            pnlsideCreateAccount.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.EXPENSE;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 627);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.Violet;
            lblLogin.Location = new Point(801, 41);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(336, 52);
            lblLogin.TabIndex = 24;
            lblLogin.Text = "Create Account";
            // 
            // btnBackToLoginCreateAccountOne
            // 
            btnBackToLoginCreateAccountOne.BackColor = Color.Red;
            btnBackToLoginCreateAccountOne.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackToLoginCreateAccountOne.ForeColor = Color.White;
            btnBackToLoginCreateAccountOne.Location = new Point(1300, 29);
            btnBackToLoginCreateAccountOne.Name = "btnBackToLoginCreateAccountOne";
            btnBackToLoginCreateAccountOne.Size = new Size(94, 29);
            btnBackToLoginCreateAccountOne.TabIndex = 25;
            btnBackToLoginCreateAccountOne.Text = "X";
            btnBackToLoginCreateAccountOne.UseVisualStyleBackColor = false;
            btnBackToLoginCreateAccountOne.MouseClick += btnBackToLoginCreateAccountOne_MouseClick;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(btnBackToLoginCreateAccountOne);
            Controls.Add(lblLogin);
            Controls.Add(pnlCreateAccountBack);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            FormClosing += CreateAccount_FormClosing;
            Load += CreateAccount_Load;
            MouseDown += CreateAccount_MouseDown;
            MouseMove += CreateAccount_MouseMove;
            MouseUp += CreateAccount_MouseUp;
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).EndInit();
            pnlCreateAccountBack.ResumeLayout(false);
            pnlCreateAccountBack.PerformLayout();
            pnlsideCreateAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblDateOfBirth;
        private CheckedListBox chkLstBoxGender;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private DateTimePicker dtDOB;
        private Label lblGender;
        private BindingSource genderBindingSource;
        private Button btnAddUser;
        private TextBox txtPassword;
        private Label lblSecretKeyQuestion;
        private TextBox txtSecretKeyQuestion;
        private Label lblSecretKeyAnswer;
        private TextBox txtSecretKeyAnswer;
        private Panel pnlCreateAccountBack;
        private Panel pnlsideCreateAccount;
        private PictureBox pictureBox1;
        private CheckBox chkShowPasswordCreate;
        private Label lblLogin;
        private Button btnBackToLoginCreateAccountOne;
    }
}