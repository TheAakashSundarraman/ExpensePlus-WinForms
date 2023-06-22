namespace ExpensePlus
{
    partial class LeftNavigation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnDashboard = new PictureBox();
            btnInvestments = new PictureBox();
            btnExpenses = new PictureBox();
            btnReporting = new PictureBox();
            btnProfile = new PictureBox();
            btnLogout = new PictureBox();
            txtUserInfo = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInvestments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExpenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReporting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDashboard, 0, 1);
            tableLayoutPanel1.Controls.Add(btnInvestments, 0, 2);
            tableLayoutPanel1.Controls.Add(btnExpenses, 0, 3);
            tableLayoutPanel1.Controls.Add(btnReporting, 0, 4);
            tableLayoutPanel1.Controls.Add(btnProfile, 0, 5);
            tableLayoutPanel1.Controls.Add(btnLogout, 0, 6);
            tableLayoutPanel1.Controls.Add(txtUserInfo, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.710001F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.710001F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.710001F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.710001F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.710001F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.710001F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7400007F));
            tableLayoutPanel1.Size = new Size(250, 806);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.EXPENSE1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.Location = new Point(3, 204);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(244, 80);
            btnDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            btnDashboard.TabIndex = 1;
            btnDashboard.TabStop = false;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseHover += btnDashboard_MouseHover;
            // 
            // btnInvestments
            // 
            btnInvestments.Cursor = Cursors.Hand;
            btnInvestments.Dock = DockStyle.Fill;
            btnInvestments.Image = Properties.Resources.money;
            btnInvestments.Location = new Point(3, 290);
            btnInvestments.Name = "btnInvestments";
            btnInvestments.Size = new Size(244, 80);
            btnInvestments.SizeMode = PictureBoxSizeMode.Zoom;
            btnInvestments.TabIndex = 2;
            btnInvestments.TabStop = false;
            btnInvestments.Click += btnInvestments_Click;
            btnInvestments.MouseHover += btnInvestments_MouseHover;
            // 
            // btnExpenses
            // 
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.Dock = DockStyle.Fill;
            btnExpenses.Image = Properties.Resources.expenses;
            btnExpenses.Location = new Point(3, 376);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(244, 80);
            btnExpenses.SizeMode = PictureBoxSizeMode.Zoom;
            btnExpenses.TabIndex = 3;
            btnExpenses.TabStop = false;
            btnExpenses.Click += btnExpenses_Click;
            btnExpenses.MouseHover += btnExpenses_MouseHover;
            // 
            // btnReporting
            // 
            btnReporting.Cursor = Cursors.Hand;
            btnReporting.Dock = DockStyle.Fill;
            btnReporting.Image = Properties.Resources.calculator;
            btnReporting.Location = new Point(3, 462);
            btnReporting.Name = "btnReporting";
            btnReporting.Size = new Size(244, 80);
            btnReporting.SizeMode = PictureBoxSizeMode.Zoom;
            btnReporting.TabIndex = 4;
            btnReporting.TabStop = false;
            btnReporting.Click += btnReporting_Click;
            btnReporting.MouseHover += btnReporting_MouseHover;
            // 
            // btnProfile
            // 
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Dock = DockStyle.Fill;
            btnProfile.Image = Properties.Resources.Profile;
            btnProfile.Location = new Point(3, 548);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(244, 80);
            btnProfile.SizeMode = PictureBoxSizeMode.Zoom;
            btnProfile.TabIndex = 5;
            btnProfile.TabStop = false;
            btnProfile.Click += btnProfile_Click;
            btnProfile.MouseHover += btnProfile_MouseHover;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.Image = Properties.Resources.clipart1898966;
            btnLogout.Location = new Point(3, 634);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(244, 80);
            btnLogout.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogout.TabIndex = 6;
            btnLogout.TabStop = false;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseHover += btnLogout_MouseHover;
            // 
            // txtUserInfo
            // 
            txtUserInfo.Dock = DockStyle.Fill;
            txtUserInfo.Location = new Point(3, 720);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.ReadOnly = true;
            txtUserInfo.Size = new Size(244, 83);
            txtUserInfo.TabIndex = 7;
            txtUserInfo.Text = "";
            // 
            // LeftNavigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LeftNavigation";
            Size = new Size(250, 806);
            Load += LeftNavigation_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInvestments).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExpenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReporting).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox btnDashboard;
        private PictureBox btnInvestments;
        private PictureBox btnExpenses;
        private PictureBox btnReporting;
        private PictureBox btnProfile;
        private PictureBox btnLogout;
        private RichTextBox txtUserInfo;
    }
}
