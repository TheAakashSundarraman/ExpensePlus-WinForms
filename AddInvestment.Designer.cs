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
            SuspendLayout();
            // 
            // lblInvestmentName
            // 
            lblInvestmentName.AutoSize = true;
            lblInvestmentName.Location = new Point(211, 51);
            lblInvestmentName.Name = "lblInvestmentName";
            lblInvestmentName.Size = new Size(101, 15);
            lblInvestmentName.TabIndex = 0;
            lblInvestmentName.Text = "Investment Name";
            // 
            // txtInvestmentName
            // 
            txtInvestmentName.Location = new Point(369, 49);
            txtInvestmentName.Margin = new Padding(3, 2, 3, 2);
            txtInvestmentName.Name = "txtInvestmentName";
            txtInvestmentName.Size = new Size(274, 23);
            txtInvestmentName.TabIndex = 1;
            // 
            // lblInvestmentType
            // 
            lblInvestmentType.AutoSize = true;
            lblInvestmentType.Location = new Point(211, 114);
            lblInvestmentType.Name = "lblInvestmentType";
            lblInvestmentType.Size = new Size(93, 15);
            lblInvestmentType.TabIndex = 2;
            lblInvestmentType.Text = "Investment Type";
            // 
            // cmbInvestmentType
            // 
            cmbInvestmentType.FormattingEnabled = true;
            cmbInvestmentType.Location = new Point(369, 112);
            cmbInvestmentType.Margin = new Padding(3, 2, 3, 2);
            cmbInvestmentType.Name = "cmbInvestmentType";
            cmbInvestmentType.Size = new Size(274, 23);
            cmbInvestmentType.TabIndex = 3;
            // 
            // lblInvestmentDate
            // 
            lblInvestmentDate.AutoSize = true;
            lblInvestmentDate.Location = new Point(211, 172);
            lblInvestmentDate.Name = "lblInvestmentDate";
            lblInvestmentDate.Size = new Size(93, 15);
            lblInvestmentDate.TabIndex = 4;
            lblInvestmentDate.Text = "Investment Date";
            // 
            // dtInvestmentDate
            // 
            dtInvestmentDate.CustomFormat = "dd/MM/yyyy";
            dtInvestmentDate.Location = new Point(369, 167);
            dtInvestmentDate.Margin = new Padding(3, 2, 3, 2);
            dtInvestmentDate.Name = "dtInvestmentDate";
            dtInvestmentDate.Size = new Size(274, 23);
            dtInvestmentDate.TabIndex = 5;
            // 
            // txtInvestmentAmount
            // 
            txtInvestmentAmount.Location = new Point(369, 221);
            txtInvestmentAmount.Margin = new Padding(3, 2, 3, 2);
            txtInvestmentAmount.Name = "txtInvestmentAmount";
            txtInvestmentAmount.Size = new Size(274, 23);
            txtInvestmentAmount.TabIndex = 7;
            // 
            // lblInvestmentAmount
            // 
            lblInvestmentAmount.AutoSize = true;
            lblInvestmentAmount.Location = new Point(211, 224);
            lblInvestmentAmount.Name = "lblInvestmentAmount";
            lblInvestmentAmount.Size = new Size(113, 15);
            lblInvestmentAmount.TabIndex = 6;
            lblInvestmentAmount.Text = "Investment Amount";
            // 
            // lblInvestmentDescription
            // 
            lblInvestmentDescription.AutoSize = true;
            lblInvestmentDescription.Location = new Point(211, 272);
            lblInvestmentDescription.Name = "lblInvestmentDescription";
            lblInvestmentDescription.Size = new Size(129, 15);
            lblInvestmentDescription.TabIndex = 8;
            lblInvestmentDescription.Text = "Investment Description";
            // 
            // txtInvestmentDescription
            // 
            txtInvestmentDescription.Location = new Point(369, 269);
            txtInvestmentDescription.Margin = new Padding(3, 2, 3, 2);
            txtInvestmentDescription.Multiline = true;
            txtInvestmentDescription.Name = "txtInvestmentDescription";
            txtInvestmentDescription.Size = new Size(294, 58);
            txtInvestmentDescription.TabIndex = 9;
            // 
            // btnAddInvestment
            // 
            btnAddInvestment.Location = new Point(267, 379);
            btnAddInvestment.Margin = new Padding(3, 2, 3, 2);
            btnAddInvestment.Name = "btnAddInvestment";
            btnAddInvestment.Size = new Size(132, 22);
            btnAddInvestment.TabIndex = 10;
            btnAddInvestment.Text = "Add Investment";
            btnAddInvestment.UseVisualStyleBackColor = true;
            btnAddInvestment.Click += btnAddInvestment_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(432, 379);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // AddInvestment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 569);
            Controls.Add(btnClear);
            Controls.Add(btnAddInvestment);
            Controls.Add(txtInvestmentDescription);
            Controls.Add(lblInvestmentDescription);
            Controls.Add(txtInvestmentAmount);
            Controls.Add(lblInvestmentAmount);
            Controls.Add(dtInvestmentDate);
            Controls.Add(lblInvestmentDate);
            Controls.Add(cmbInvestmentType);
            Controls.Add(lblInvestmentType);
            Controls.Add(txtInvestmentName);
            Controls.Add(lblInvestmentName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddInvestment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Investment";
            FormClosing += AddInvestment_FormClosing;
            Load += AddInvestment_Load;
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
    }
}