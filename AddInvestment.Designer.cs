namespace ExpensePlus
{
    partial class AddInvestment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInvestment));
            lblInvestmentName = new Label();
            txtInvestmentName = new TextBox();
            lblInvestmentType = new Label();
            cmbInvestmentType = new ComboBox();
            lblInvestmentDate = new Label();
            dtInvestmentDate = new DateTimePicker();
            txtInvestmentAmount = new TextBox();
            lblInvestmentAmount = new Label();
            lblInvestmentDescription = new Label();
            txtInvestmentDescription = new TextBox();
            btnAddInvestment = new Button();
            btnClear = new Button();
            pnlLeftNav = new Panel();
            panel1 = new Panel();
            pnlAddInvestmentHeaders = new Panel();
            lblCreateInvestmentHeader = new Label();
            panel1.SuspendLayout();
            pnlAddInvestmentHeaders.SuspendLayout();
            SuspendLayout();
            // 
            // lblInvestmentName
            // 
            lblInvestmentName.AutoSize = true;
            lblInvestmentName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvestmentName.Location = new Point(15, 27);
            lblInvestmentName.Name = "lblInvestmentName";
            lblInvestmentName.Size = new Size(156, 20);
            lblInvestmentName.TabIndex = 0;
            lblInvestmentName.Text = "Investment Name";
            // 
            // txtInvestmentName
            // 
            txtInvestmentName.Location = new Point(15, 63);
            txtInvestmentName.Name = "txtInvestmentName";
            txtInvestmentName.Size = new Size(313, 27);
            txtInvestmentName.TabIndex = 1;
            // 
            // lblInvestmentType
            // 
            lblInvestmentType.AutoSize = true;
            lblInvestmentType.Location = new Point(466, 27);
            lblInvestmentType.Name = "lblInvestmentType";
            lblInvestmentType.Size = new Size(116, 20);
            lblInvestmentType.TabIndex = 2;
            lblInvestmentType.Text = "Investment Type";
            // 
            // cmbInvestmentType
            // 
            cmbInvestmentType.FormattingEnabled = true;
            cmbInvestmentType.Location = new Point(466, 63);
            cmbInvestmentType.Name = "cmbInvestmentType";
            cmbInvestmentType.Size = new Size(313, 28);
            cmbInvestmentType.TabIndex = 3;
            cmbInvestmentType.SelectedIndexChanged += cmbInvestmentType_SelectedIndexChanged;
            // 
            // lblInvestmentDate
            // 
            lblInvestmentDate.AutoSize = true;
            lblInvestmentDate.Location = new Point(15, 117);
            lblInvestmentDate.Name = "lblInvestmentDate";
            lblInvestmentDate.Size = new Size(117, 20);
            lblInvestmentDate.TabIndex = 4;
            lblInvestmentDate.Text = "Investment Date";
            // 
            // dtInvestmentDate
            // 
            dtInvestmentDate.CustomFormat = "dd/MMM/yyyy";
            dtInvestmentDate.Location = new Point(15, 148);
            dtInvestmentDate.Name = "dtInvestmentDate";
            dtInvestmentDate.Size = new Size(313, 27);
            dtInvestmentDate.TabIndex = 5;
            // 
            // txtInvestmentAmount
            // 
            txtInvestmentAmount.Location = new Point(466, 150);
            txtInvestmentAmount.Name = "txtInvestmentAmount";
            txtInvestmentAmount.PlaceholderText = "$";
            txtInvestmentAmount.Size = new Size(313, 27);
            txtInvestmentAmount.TabIndex = 7;
            // 
            // lblInvestmentAmount
            // 
            lblInvestmentAmount.AutoSize = true;
            lblInvestmentAmount.Location = new Point(468, 117);
            lblInvestmentAmount.Name = "lblInvestmentAmount";
            lblInvestmentAmount.Size = new Size(160, 20);
            lblInvestmentAmount.TabIndex = 6;
            lblInvestmentAmount.Text = "Investment Amount ($)";
            // 
            // lblInvestmentDescription
            // 
            lblInvestmentDescription.AutoSize = true;
            lblInvestmentDescription.Location = new Point(330, 214);
            lblInvestmentDescription.Name = "lblInvestmentDescription";
            lblInvestmentDescription.Size = new Size(161, 20);
            lblInvestmentDescription.TabIndex = 8;
            lblInvestmentDescription.Text = "Investment Description";
            // 
            // txtInvestmentDescription
            // 
            txtInvestmentDescription.Location = new Point(101, 246);
            txtInvestmentDescription.Multiline = true;
            txtInvestmentDescription.Name = "txtInvestmentDescription";
            txtInvestmentDescription.Size = new Size(633, 127);
            txtInvestmentDescription.TabIndex = 9;
            // 
            // btnAddInvestment
            // 
            btnAddInvestment.BackColor = Color.PaleVioletRed;
            btnAddInvestment.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddInvestment.Location = new Point(296, 406);
            btnAddInvestment.Name = "btnAddInvestment";
            btnAddInvestment.Size = new Size(242, 60);
            btnAddInvestment.TabIndex = 10;
            btnAddInvestment.Text = "Add Investment";
            btnAddInvestment.UseVisualStyleBackColor = false;
            btnAddInvestment.Click += btnAddInvestment_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            btnClear.Location = new Point(373, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // pnlLeftNav
            // 
            pnlLeftNav.BackColor = Color.WhiteSmoke;
            pnlLeftNav.Dock = DockStyle.Left;
            pnlLeftNav.Location = new Point(0, 0);
            pnlLeftNav.Name = "pnlLeftNav";
            pnlLeftNav.Size = new Size(280, 806);
            pnlLeftNav.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(pnlAddInvestmentHeaders);
            panel1.Location = new Point(357, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 648);
            panel1.TabIndex = 13;
            // 
            // pnlAddInvestmentHeaders
            // 
            pnlAddInvestmentHeaders.BackColor = Color.WhiteSmoke;
            pnlAddInvestmentHeaders.Controls.Add(btnClear);
            pnlAddInvestmentHeaders.Controls.Add(txtInvestmentDescription);
            pnlAddInvestmentHeaders.Controls.Add(btnAddInvestment);
            pnlAddInvestmentHeaders.Controls.Add(lblInvestmentName);
            pnlAddInvestmentHeaders.Controls.Add(txtInvestmentName);
            pnlAddInvestmentHeaders.Controls.Add(lblInvestmentType);
            pnlAddInvestmentHeaders.Controls.Add(lblInvestmentDescription);
            pnlAddInvestmentHeaders.Controls.Add(txtInvestmentAmount);
            pnlAddInvestmentHeaders.Controls.Add(dtInvestmentDate);
            pnlAddInvestmentHeaders.Controls.Add(cmbInvestmentType);
            pnlAddInvestmentHeaders.Controls.Add(lblInvestmentAmount);
            pnlAddInvestmentHeaders.Controls.Add(lblInvestmentDate);
            pnlAddInvestmentHeaders.Location = new Point(69, 53);
            pnlAddInvestmentHeaders.Name = "pnlAddInvestmentHeaders";
            pnlAddInvestmentHeaders.Size = new Size(838, 539);
            pnlAddInvestmentHeaders.TabIndex = 12;
            // 
            // lblCreateInvestmentHeader
            // 
            lblCreateInvestmentHeader.AutoSize = true;
            lblCreateInvestmentHeader.BackColor = Color.Transparent;
            lblCreateInvestmentHeader.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCreateInvestmentHeader.ForeColor = Color.PaleVioletRed;
            lblCreateInvestmentHeader.Location = new Point(709, 43);
            lblCreateInvestmentHeader.Name = "lblCreateInvestmentHeader";
            lblCreateInvestmentHeader.Size = new Size(299, 40);
            lblCreateInvestmentHeader.TabIndex = 15;
            lblCreateInvestmentHeader.Text = "New Investment";
            // 
            // AddInvestment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(lblCreateInvestmentHeader);
            Controls.Add(pnlLeftNav);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddInvestment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Investment";
            FormClosing += AddInvestment_FormClosing;
            Load += AddInvestment_Load;
            MouseDown += AddInvestment_MouseDown;
            MouseMove += AddInvestment_MouseMove;
            MouseUp += AddInvestment_MouseUp;
            panel1.ResumeLayout(false);
            pnlAddInvestmentHeaders.ResumeLayout(false);
            pnlAddInvestmentHeaders.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvestmentName;
        private TextBox txtInvestmentName;
        private Label lblInvestmentType;
        private ComboBox cmbInvestmentType;
        private Label lblInvestmentDate;
        private DateTimePicker dtInvestmentDate;
        private TextBox txtInvestmentAmount;
        private Label lblInvestmentAmount;
        private Label lblInvestmentDescription;
        private TextBox txtInvestmentDescription;
        private Button btnAddInvestment;
        private Button btnClear;
        private Panel pnlLeftNav;
        private Panel panel1;
        private Label lblCreateInvestmentHeader;
        private Panel pnlAddInvestmentHeaders;
    }
}