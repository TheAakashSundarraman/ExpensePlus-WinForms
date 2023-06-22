namespace ExpensePlus
{
    partial class AddExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpenses));
            lblCreateExpenseHeader = new Label();
            pnlCreateExpense = new Panel();
            btnAddModifyExpense = new Button();
            dtExpenseDate = new DateTimePicker();
            lblExpenseDate = new Label();
            txtExpenseDescription = new TextBox();
            lblExpenseDescription = new Label();
            cmbExpenseType = new ComboBox();
            txtExpenseAmount = new TextBox();
            lblExpenseAmount = new Label();
            lblExpenseType = new Label();
            txtExpenseName = new TextBox();
            lblExpenseName = new Label();
            pnlLeftNavigation = new Panel();
            pnlCreateExpense.SuspendLayout();
            SuspendLayout();
            // 
            // lblCreateExpenseHeader
            // 
            lblCreateExpenseHeader.AutoSize = true;
            lblCreateExpenseHeader.BackColor = Color.White;
            lblCreateExpenseHeader.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCreateExpenseHeader.ForeColor = Color.PaleVioletRed;
            lblCreateExpenseHeader.Location = new Point(691, 48);
            lblCreateExpenseHeader.Name = "lblCreateExpenseHeader";
            lblCreateExpenseHeader.Size = new Size(251, 40);
            lblCreateExpenseHeader.TabIndex = 0;
            lblCreateExpenseHeader.Text = "New Expense";
            // 
            // pnlCreateExpense
            // 
            pnlCreateExpense.BackColor = Color.WhiteSmoke;
            pnlCreateExpense.Controls.Add(btnAddModifyExpense);
            pnlCreateExpense.Controls.Add(dtExpenseDate);
            pnlCreateExpense.Controls.Add(lblExpenseDate);
            pnlCreateExpense.Controls.Add(txtExpenseDescription);
            pnlCreateExpense.Controls.Add(lblExpenseDescription);
            pnlCreateExpense.Controls.Add(cmbExpenseType);
            pnlCreateExpense.Controls.Add(txtExpenseAmount);
            pnlCreateExpense.Controls.Add(lblExpenseAmount);
            pnlCreateExpense.Controls.Add(lblExpenseType);
            pnlCreateExpense.Controls.Add(txtExpenseName);
            pnlCreateExpense.Controls.Add(lblExpenseName);
            pnlCreateExpense.Location = new Point(309, 111);
            pnlCreateExpense.Name = "pnlCreateExpense";
            pnlCreateExpense.Size = new Size(1038, 594);
            pnlCreateExpense.TabIndex = 4;
            // 
            // btnAddModifyExpense
            // 
            btnAddModifyExpense.BackColor = Color.PaleVioletRed;
            btnAddModifyExpense.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddModifyExpense.Location = new Point(382, 475);
            btnAddModifyExpense.Name = "btnAddModifyExpense";
            btnAddModifyExpense.Size = new Size(242, 60);
            btnAddModifyExpense.TabIndex = 6;
            btnAddModifyExpense.Text = "Create Expense";
            btnAddModifyExpense.UseVisualStyleBackColor = false;
            btnAddModifyExpense.Click += btnAddModifyExpense_Click;
            // 
            // dtExpenseDate
            // 
            dtExpenseDate.CalendarFont = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtExpenseDate.CalendarForeColor = Color.White;
            dtExpenseDate.CalendarMonthBackground = Color.Violet;
            dtExpenseDate.CalendarTitleBackColor = Color.Violet;
            dtExpenseDate.CalendarTitleForeColor = Color.White;
            dtExpenseDate.CustomFormat = "dd/MMM/yyyy";
            dtExpenseDate.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtExpenseDate.Location = new Point(764, 112);
            dtExpenseDate.Name = "dtExpenseDate";
            dtExpenseDate.Size = new Size(250, 27);
            dtExpenseDate.TabIndex = 4;
            // 
            // lblExpenseDate
            // 
            lblExpenseDate.AutoSize = true;
            lblExpenseDate.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseDate.Location = new Point(764, 79);
            lblExpenseDate.Name = "lblExpenseDate";
            lblExpenseDate.Size = new Size(124, 20);
            lblExpenseDate.TabIndex = 9;
            lblExpenseDate.Text = "Expense Date";
            // 
            // txtExpenseDescription
            // 
            txtExpenseDescription.Location = new Point(209, 242);
            txtExpenseDescription.Multiline = true;
            txtExpenseDescription.Name = "txtExpenseDescription";
            txtExpenseDescription.Size = new Size(602, 209);
            txtExpenseDescription.TabIndex = 5;
            // 
            // lblExpenseDescription
            // 
            lblExpenseDescription.AutoSize = true;
            lblExpenseDescription.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseDescription.Location = new Point(417, 203);
            lblExpenseDescription.Name = "lblExpenseDescription";
            lblExpenseDescription.Size = new Size(178, 20);
            lblExpenseDescription.TabIndex = 7;
            lblExpenseDescription.Text = "Expense Description";
            // 
            // cmbExpenseType
            // 
            cmbExpenseType.FormattingEnabled = true;
            cmbExpenseType.Location = new Point(295, 113);
            cmbExpenseType.Name = "cmbExpenseType";
            cmbExpenseType.Size = new Size(151, 28);
            cmbExpenseType.TabIndex = 2;
            // 
            // txtExpenseAmount
            // 
            txtExpenseAmount.Location = new Point(509, 112);
            txtExpenseAmount.Name = "txtExpenseAmount";
            txtExpenseAmount.PlaceholderText = "$";
            txtExpenseAmount.Size = new Size(202, 27);
            txtExpenseAmount.TabIndex = 3;
            // 
            // lblExpenseAmount
            // 
            lblExpenseAmount.AutoSize = true;
            lblExpenseAmount.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseAmount.Location = new Point(509, 79);
            lblExpenseAmount.Name = "lblExpenseAmount";
            lblExpenseAmount.Size = new Size(177, 20);
            lblExpenseAmount.TabIndex = 4;
            lblExpenseAmount.Text = "Expense Amount ($)";
            // 
            // lblExpenseType
            // 
            lblExpenseType.AutoSize = true;
            lblExpenseType.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseType.Location = new Point(295, 79);
            lblExpenseType.Name = "lblExpenseType";
            lblExpenseType.Size = new Size(126, 20);
            lblExpenseType.TabIndex = 2;
            lblExpenseType.Text = "Expense Type";
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(33, 112);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(202, 27);
            txtExpenseName.TabIndex = 1;
            // 
            // lblExpenseName
            // 
            lblExpenseName.AutoSize = true;
            lblExpenseName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpenseName.Location = new Point(33, 79);
            lblExpenseName.Name = "lblExpenseName";
            lblExpenseName.Size = new Size(132, 20);
            lblExpenseName.TabIndex = 0;
            lblExpenseName.Text = "Expense Name";
            // 
            // pnlLeftNavigation
            // 
            pnlLeftNavigation.BackColor = Color.WhiteSmoke;
            pnlLeftNavigation.Dock = DockStyle.Left;
            pnlLeftNavigation.Location = new Point(0, 0);
            pnlLeftNavigation.Name = "pnlLeftNavigation";
            pnlLeftNavigation.Size = new Size(250, 806);
            pnlLeftNavigation.TabIndex = 5;
            // 
            // AddExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(pnlLeftNavigation);
            Controls.Add(pnlCreateExpense);
            Controls.Add(lblCreateExpenseHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddExpenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExpenses";
            FormClosing += AddExpenses_FormClosing;
            Load += AddExpenses_Load;
            MouseDown += AddExpenses_MouseDown;
            MouseMove += AddExpenses_MouseMove;
            MouseUp += AddExpenses_MouseUp;
            pnlCreateExpense.ResumeLayout(false);
            pnlCreateExpense.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateExpenseHeader;
        private Panel pnlCreateExpense;
        private TextBox txtExpenseAmount;
        private Label lblExpenseAmount;
        private Label lblExpenseType;
        private TextBox txtExpenseName;
        private Label lblExpenseName;
        private ComboBox cmbExpenseType;
        private DateTimePicker dtExpenseDate;
        private Label lblExpenseDate;
        private TextBox txtExpenseDescription;
        private Label lblExpenseDescription;
        private Button btnAddModifyExpense;
        private Panel pnlLeftNavigation;
    }
}