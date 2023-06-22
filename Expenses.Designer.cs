namespace ExpensePlus
{
    partial class Expenses
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            dgExpenses = new DataGridView();
            btnUpdateExpenses = new Button();
            btnDeleteExpenses = new Button();
            btnAddNewExpense = new Button();
            pnlExpense2 = new Panel();
            lblHighestExpense = new Label();
            lblHighestExpenseHeader = new Label();
            pnlExpense3 = new Panel();
            lblMostFrequent = new Label();
            lblMostFrequentHeader = new Label();
            chrtExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            btnExpensesExitApp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgExpenses).BeginInit();
            pnlExpense2.SuspendLayout();
            pnlExpense3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chrtExpenses).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgExpenses
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExpenses.Dock = DockStyle.Fill;
            dgExpenses.Location = new Point(0, 0);
            dgExpenses.Name = "dgExpenses";
            dgExpenses.RowHeadersWidth = 51;
            dgExpenses.RowTemplate.Height = 29;
            dgExpenses.Size = new Size(1110, 392);
            dgExpenses.TabIndex = 0;
            // 
            // btnUpdateExpenses
            // 
            btnUpdateExpenses.BackColor = Color.Chartreuse;
            btnUpdateExpenses.Location = new Point(1168, 332);
            btnUpdateExpenses.Name = "btnUpdateExpenses";
            btnUpdateExpenses.Size = new Size(94, 29);
            btnUpdateExpenses.TabIndex = 2;
            btnUpdateExpenses.Text = "Update";
            btnUpdateExpenses.UseVisualStyleBackColor = false;
            btnUpdateExpenses.Click += btnUpdateExpenses_Click;
            // 
            // btnDeleteExpenses
            // 
            btnDeleteExpenses.BackColor = Color.Red;
            btnDeleteExpenses.ForeColor = Color.White;
            btnDeleteExpenses.Location = new Point(1293, 332);
            btnDeleteExpenses.Name = "btnDeleteExpenses";
            btnDeleteExpenses.Size = new Size(94, 29);
            btnDeleteExpenses.TabIndex = 3;
            btnDeleteExpenses.Text = "Delete";
            btnDeleteExpenses.UseVisualStyleBackColor = false;
            btnDeleteExpenses.Click += btnDeleteExpenses_Click;
            // 
            // btnAddNewExpense
            // 
            btnAddNewExpense.BackColor = Color.Thistle;
            btnAddNewExpense.Location = new Point(905, 38);
            btnAddNewExpense.Name = "btnAddNewExpense";
            btnAddNewExpense.Size = new Size(482, 56);
            btnAddNewExpense.TabIndex = 4;
            btnAddNewExpense.Text = "New Expense";
            btnAddNewExpense.UseVisualStyleBackColor = false;
            btnAddNewExpense.Click += btnAddNewExpense_Click;
            // 
            // pnlExpense2
            // 
            pnlExpense2.BackColor = Color.LavenderBlush;
            pnlExpense2.Controls.Add(lblHighestExpense);
            pnlExpense2.Controls.Add(lblHighestExpenseHeader);
            pnlExpense2.Location = new Point(905, 118);
            pnlExpense2.Name = "pnlExpense2";
            pnlExpense2.Size = new Size(218, 145);
            pnlExpense2.TabIndex = 2;
            // 
            // lblHighestExpense
            // 
            lblHighestExpense.AutoSize = true;
            lblHighestExpense.Location = new Point(18, 70);
            lblHighestExpense.Name = "lblHighestExpense";
            lblHighestExpense.Size = new Size(27, 20);
            lblHighestExpense.TabIndex = 6;
            lblHighestExpense.Text = "lbl";
            // 
            // lblHighestExpenseHeader
            // 
            lblHighestExpenseHeader.AutoSize = true;
            lblHighestExpenseHeader.Location = new Point(39, 19);
            lblHighestExpenseHeader.Name = "lblHighestExpenseHeader";
            lblHighestExpenseHeader.Size = new Size(146, 20);
            lblHighestExpenseHeader.TabIndex = 6;
            lblHighestExpenseHeader.Text = "Highest Expense";
            // 
            // pnlExpense3
            // 
            pnlExpense3.BackColor = Color.LavenderBlush;
            pnlExpense3.Controls.Add(lblMostFrequent);
            pnlExpense3.Controls.Add(lblMostFrequentHeader);
            pnlExpense3.Location = new Point(1168, 118);
            pnlExpense3.Name = "pnlExpense3";
            pnlExpense3.Size = new Size(219, 145);
            pnlExpense3.TabIndex = 3;
            // 
            // lblMostFrequent
            // 
            lblMostFrequent.AutoSize = true;
            lblMostFrequent.Location = new Point(23, 70);
            lblMostFrequent.Name = "lblMostFrequent";
            lblMostFrequent.Size = new Size(57, 20);
            lblMostFrequent.TabIndex = 6;
            lblMostFrequent.Text = "label1";
            // 
            // lblMostFrequentHeader
            // 
            lblMostFrequentHeader.AutoSize = true;
            lblMostFrequentHeader.Location = new Point(47, 19);
            lblMostFrequentHeader.Name = "lblMostFrequentHeader";
            lblMostFrequentHeader.Size = new Size(131, 20);
            lblMostFrequentHeader.TabIndex = 7;
            lblMostFrequentHeader.Text = "Most Frequent";
            // 
            // chrtExpenses
            // 
            chartArea1.Name = "ChartArea1";
            chrtExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chrtExpenses.Legends.Add(legend1);
            chrtExpenses.Location = new Point(286, 12);
            chrtExpenses.Name = "chrtExpenses";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
            series1.Legend = "Legend1";
            series1.Name = "funnelSeries";
            series1.ToolTip = "#VALX{G} #VAL{C}";
            chrtExpenses.Series.Add(series1);
            chrtExpenses.Size = new Size(574, 334);
            chrtExpenses.TabIndex = 0;
            chrtExpenses.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 806);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(250, 806);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgExpenses);
            panel2.Location = new Point(286, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 392);
            panel2.TabIndex = 6;
            // 
            // btnExpensesExitApp
            // 
            btnExpensesExitApp.BackColor = Color.Red;
            btnExpensesExitApp.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExpensesExitApp.ForeColor = Color.White;
            btnExpensesExitApp.Location = new Point(1375, 12);
            btnExpensesExitApp.Name = "btnExpensesExitApp";
            btnExpensesExitApp.Size = new Size(30, 29);
            btnExpensesExitApp.TabIndex = 13;
            btnExpensesExitApp.Text = "X";
            btnExpensesExitApp.UseVisualStyleBackColor = false;
            btnExpensesExitApp.Click += btnExpensesExitApp_Click;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(btnExpensesExitApp);
            Controls.Add(chrtExpenses);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlExpense3);
            Controls.Add(pnlExpense2);
            Controls.Add(btnAddNewExpense);
            Controls.Add(btnDeleteExpenses);
            Controls.Add(btnUpdateExpenses);
            Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Expenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expenses";
            FormClosing += Expenses_FormClosing;
            Load += Expenses_Load;
            MouseDown += Expenses_MouseDown;
            MouseMove += Expenses_MouseMove;
            MouseUp += Expenses_MouseUp;
            ((System.ComponentModel.ISupportInitialize)dgExpenses).EndInit();
            pnlExpense2.ResumeLayout(false);
            pnlExpense2.PerformLayout();
            pnlExpense3.ResumeLayout(false);
            pnlExpense3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chrtExpenses).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgExpenses;
        private Button btnUpdateExpenses;
        private Button btnDeleteExpenses;
        private Button btnAddNewExpense;
        private Panel pnlExpense2;
        private Panel pnlExpense3;
        private Label lblHighestExpenseHeader;
        private Label lblMostFrequentHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtExpenses;
        private Panel panel1;
        private Label lblHighestExpense;
        private Label lblMostFrequent;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button btnExpensesExitApp;
    }
}