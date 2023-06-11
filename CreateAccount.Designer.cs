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
            lblUserName = new Label();
            picLogo = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(232, 252);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(101, 20);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "First Name";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.EXPENSE;
            picLogo.Location = new Point(-4, -1);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(221, 202);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(469, 252);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(1177, 252);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(61, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(947, 252);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(703, 252);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(232, 428);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(115, 20);
            lblDateOfBirth.TabIndex = 8;
            lblDateOfBirth.Text = "Date of birth";
            // 
            // chkLstBoxGender
            // 
            chkLstBoxGender.FormattingEnabled = true;
            chkLstBoxGender.Location = new Point(658, 475);
            chkLstBoxGender.Name = "chkLstBoxGender";
            chkLstBoxGender.Size = new Size(150, 114);
            chkLstBoxGender.TabIndex = 9;
            chkLstBoxGender.ThreeDCheckBoxes = true;
            chkLstBoxGender.ItemCheck += chkLstBoxGender_ItemCheck;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(232, 310);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(179, 27);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(469, 310);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 27);
            txtLastName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(947, 310);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(1177, 310);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(179, 27);
            txtPhone.TabIndex = 14;
            // 
            // dtDOB
            // 
            dtDOB.CalendarFont = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtDOB.CalendarForeColor = Color.White;
            dtDOB.CalendarMonthBackground = Color.Violet;
            dtDOB.CalendarTitleBackColor = Color.Violet;
            dtDOB.CalendarTitleForeColor = Color.White;
            dtDOB.CustomFormat = "dd-MMM-yyyy";
            dtDOB.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtDOB.Location = new Point(232, 475);
            dtDOB.Name = "dtDOB";
            dtDOB.Size = new Size(250, 27);
            dtDOB.TabIndex = 15;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(658, 428);
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
            btnAddUser.Location = new Point(658, 631);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(150, 69);
            btnAddUser.TabIndex = 17;
            btnAddUser.Text = "Create";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(703, 310);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(207, 27);
            txtPassword.TabIndex = 18;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1399, 759);
            Controls.Add(txtPassword);
            Controls.Add(btnAddUser);
            Controls.Add(lblGender);
            Controls.Add(dtDOB);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(chkLstBoxGender);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblLastName);
            Controls.Add(picLogo);
            Controls.Add(lblUserName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            FormClosed += CreateAccount_FormClosed;
            Load += CreateAccount_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private PictureBox picLogo;
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
    }
}