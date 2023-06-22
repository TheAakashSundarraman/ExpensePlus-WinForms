namespace ExpensePlus
{
    partial class Reports
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            tableLayoutPanel1 = new TableLayoutPanel();
            dgInvestments = new DataGridView();
            dgExpenses = new DataGridView();
            btnExportInvstmentToCSV = new Button();
            btnExportExpensestoCSV = new Button();
            pnlLeftNavigation = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgInvestments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgExpenses).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgInvestments, 0, 1);
            tableLayoutPanel1.Controls.Add(dgExpenses, 1, 1);
            tableLayoutPanel1.Controls.Add(btnExportInvstmentToCSV, 0, 0);
            tableLayoutPanel1.Controls.Add(btnExportExpensestoCSV, 1, 0);
            tableLayoutPanel1.Location = new Point(256, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1144, 747);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgInvestments
            // 
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgInvestments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Violet;
            dataGridViewCellStyle2.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgInvestments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgInvestments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInvestments.Dock = DockStyle.Fill;
            dgInvestments.Location = new Point(3, 112);
            dgInvestments.Name = "dgInvestments";
            dgInvestments.RowHeadersWidth = 51;
            dgInvestments.RowTemplate.Height = 29;
            dgInvestments.Size = new Size(566, 611);
            dgInvestments.TabIndex = 0;
            // 
            // dgExpenses
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExpenses.Dock = DockStyle.Fill;
            dgExpenses.Location = new Point(575, 112);
            dgExpenses.Name = "dgExpenses";
            dgExpenses.RowHeadersWidth = 51;
            dgExpenses.RowTemplate.Height = 29;
            dgExpenses.Size = new Size(566, 611);
            dgExpenses.TabIndex = 1;
            // 
            // btnExportInvstmentToCSV
            // 
            btnExportInvstmentToCSV.Dock = DockStyle.Fill;
            btnExportInvstmentToCSV.Location = new Point(3, 3);
            btnExportInvstmentToCSV.Name = "btnExportInvstmentToCSV";
            btnExportInvstmentToCSV.Size = new Size(566, 103);
            btnExportInvstmentToCSV.TabIndex = 2;
            btnExportInvstmentToCSV.Text = "Export Investments to CSV";
            btnExportInvstmentToCSV.UseVisualStyleBackColor = true;
            btnExportInvstmentToCSV.Click += btnExportInvstmentToCSV_Click;
            // 
            // btnExportExpensestoCSV
            // 
            btnExportExpensestoCSV.Dock = DockStyle.Fill;
            btnExportExpensestoCSV.Location = new Point(575, 3);
            btnExportExpensestoCSV.Name = "btnExportExpensestoCSV";
            btnExportExpensestoCSV.Size = new Size(566, 103);
            btnExportExpensestoCSV.TabIndex = 3;
            btnExportExpensestoCSV.Text = "Export Expenses to CSV";
            btnExportExpensestoCSV.UseVisualStyleBackColor = true;
            btnExportExpensestoCSV.Click += btnExportExpensestoCSV_Click;
            // 
            // pnlLeftNavigation
            // 
            pnlLeftNavigation.Dock = DockStyle.Left;
            pnlLeftNavigation.Location = new Point(0, 0);
            pnlLeftNavigation.Name = "pnlLeftNavigation";
            pnlLeftNavigation.Size = new Size(250, 806);
            pnlLeftNavigation.TabIndex = 2;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(pnlLeftNavigation);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            FormClosing += Reports_FormClosing;
            Load += Reports_Load;
            MouseDown += Reports_MouseDown;
            MouseMove += Reports_MouseMove;
            MouseUp += Reports_MouseUp;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgInvestments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgExpenses).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgInvestments;
        private DataGridView dgExpenses;
        private Button btnExportExpensestoCSV;
        private Button btnExportInvstmentToCSV;
        private Panel pnlLeftNavigation;
    }
}