namespace ExpensePlus
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pnlLeftNavigation = new Panel();
            pnlBestAsset = new Panel();
            lblBestAsset = new Label();
            lblHighestExpenseHeader = new Label();
            pnlHighestExpense = new Panel();
            lblHighestExpense = new Label();
            label2 = new Label();
            pnlTotalExpenseValue = new Panel();
            lblTotalExpenses = new Label();
            label3 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblUserName = new Label();
            panel4 = new Panel();
            btnDashboardExitApp = new Button();
            chrtInvestment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chrtExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlBestAsset.SuspendLayout();
            pnlHighestExpense.SuspendLayout();
            pnlTotalExpenseValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chrtInvestment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrtExpenses).BeginInit();
            SuspendLayout();
            // 
            // pnlLeftNavigation
            // 
            pnlLeftNavigation.BackColor = Color.WhiteSmoke;
            pnlLeftNavigation.Location = new Point(-7, 0);
            pnlLeftNavigation.Name = "pnlLeftNavigation";
            pnlLeftNavigation.Size = new Size(250, 806);
            pnlLeftNavigation.TabIndex = 0;
            // 
            // pnlBestAsset
            // 
            pnlBestAsset.BackColor = Color.SpringGreen;
            pnlBestAsset.Controls.Add(lblBestAsset);
            pnlBestAsset.Controls.Add(lblHighestExpenseHeader);
            pnlBestAsset.Location = new Point(287, 60);
            pnlBestAsset.Name = "pnlBestAsset";
            pnlBestAsset.Size = new Size(324, 238);
            pnlBestAsset.TabIndex = 0;
            // 
            // lblBestAsset
            // 
            lblBestAsset.AutoSize = true;
            lblBestAsset.Font = new Font("MS UI Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblBestAsset.Location = new Point(17, 105);
            lblBestAsset.Name = "lblBestAsset";
            lblBestAsset.Size = new Size(170, 60);
            lblBestAsset.TabIndex = 1;
            lblBestAsset.Text = "label4";
            lblBestAsset.MouseHover += lblBestAsset_MouseHover;
            // 
            // lblHighestExpenseHeader
            // 
            lblHighestExpenseHeader.AutoSize = true;
            lblHighestExpenseHeader.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHighestExpenseHeader.ForeColor = Color.White;
            lblHighestExpenseHeader.Location = new Point(17, 25);
            lblHighestExpenseHeader.Name = "lblHighestExpenseHeader";
            lblHighestExpenseHeader.Size = new Size(164, 30);
            lblHighestExpenseHeader.TabIndex = 0;
            lblHighestExpenseHeader.Text = "Best Asset";
            // 
            // pnlHighestExpense
            // 
            pnlHighestExpense.BackColor = Color.Violet;
            pnlHighestExpense.Controls.Add(lblHighestExpense);
            pnlHighestExpense.Controls.Add(label2);
            pnlHighestExpense.Location = new Point(679, 60);
            pnlHighestExpense.Name = "pnlHighestExpense";
            pnlHighestExpense.Size = new Size(324, 238);
            pnlHighestExpense.TabIndex = 1;
            // 
            // lblHighestExpense
            // 
            lblHighestExpense.AutoSize = true;
            lblHighestExpense.Font = new Font("MS UI Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblHighestExpense.Location = new Point(28, 105);
            lblHighestExpense.Name = "lblHighestExpense";
            lblHighestExpense.Size = new Size(170, 60);
            lblHighestExpense.TabIndex = 2;
            lblHighestExpense.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 25);
            label2.Name = "label2";
            label2.Size = new Size(236, 30);
            label2.TabIndex = 1;
            label2.Text = "Highest Expense";
            // 
            // pnlTotalExpenseValue
            // 
            pnlTotalExpenseValue.BackColor = Color.DarkTurquoise;
            pnlTotalExpenseValue.Controls.Add(lblTotalExpenses);
            pnlTotalExpenseValue.Controls.Add(label3);
            pnlTotalExpenseValue.Location = new Point(1066, 60);
            pnlTotalExpenseValue.Name = "pnlTotalExpenseValue";
            pnlTotalExpenseValue.Size = new Size(324, 238);
            pnlTotalExpenseValue.TabIndex = 2;
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Font = new Font("MS UI Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalExpenses.Location = new Point(17, 105);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(170, 60);
            lblTotalExpenses.TabIndex = 3;
            lblTotalExpenses.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 25);
            label3.Name = "label3";
            label3.Size = new Size(219, 30);
            label3.TabIndex = 2;
            label3.Text = "Total Expenses";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(287, 319);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "StockSeries";
            series1.ShadowColor = Color.Silver;
            chart1.Series.Add(series1);
            chart1.Size = new Size(573, 450);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.HotPink;
            lblUserName.Location = new Point(38, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(231, 30);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Users First Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 255);
            panel4.Controls.Add(btnDashboardExitApp);
            panel4.Controls.Add(lblUserName);
            panel4.Location = new Point(249, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1168, 152);
            panel4.TabIndex = 8;
            // 
            // btnDashboardExitApp
            // 
            btnDashboardExitApp.BackColor = Color.Red;
            btnDashboardExitApp.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboardExitApp.ForeColor = Color.White;
            btnDashboardExitApp.Location = new Point(1125, 14);
            btnDashboardExitApp.Name = "btnDashboardExitApp";
            btnDashboardExitApp.Size = new Size(31, 29);
            btnDashboardExitApp.TabIndex = 11;
            btnDashboardExitApp.Text = "X";
            btnDashboardExitApp.UseVisualStyleBackColor = false;
            btnDashboardExitApp.Click += btnDashboardExitApp_Click;
            // 
            // chrtInvestment
            // 
            chartArea2.Name = "ChartArea1";
            chrtInvestment.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.ShadowOffset = 2;
            chrtInvestment.Legends.Add(legend2);
            chrtInvestment.Location = new Point(931, 331);
            chrtInvestment.Name = "chrtInvestment";
            chrtInvestment.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "PieLabelStyle=Disabled, PieDrawingStyle=SoftEdge";
            series2.LabelToolTip = "#VALX{G} #TOTAL{C}";
            series2.Legend = "Legend1";
            series2.Name = "DonutSeries";
            chrtInvestment.Series.Add(series2);
            chrtInvestment.Size = new Size(459, 222);
            chrtInvestment.TabIndex = 9;
            chrtInvestment.Text = "chart2";
            chrtInvestment.Click += chrtInvestment_Click;
            // 
            // chrtExpenses
            // 
            chartArea3.Name = "ChartArea1";
            chrtExpenses.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chrtExpenses.Legends.Add(legend3);
            chrtExpenses.Location = new Point(931, 559);
            chrtExpenses.Name = "chrtExpenses";
            chrtExpenses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.CustomProperties = "PieLabelStyle=Disabled, PieDrawingStyle=SoftEdge";
            series3.LabelToolTip = "#VALX{G} #TOTAL{C}";
            series3.Legend = "Legend1";
            series3.Name = "DonutSeries";
            chrtExpenses.Series.Add(series3);
            chrtExpenses.Size = new Size(459, 222);
            chrtExpenses.TabIndex = 10;
            chrtExpenses.Text = "chart2";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(chrtExpenses);
            Controls.Add(chrtInvestment);
            Controls.Add(chart1);
            Controls.Add(pnlTotalExpenseValue);
            Controls.Add(pnlHighestExpense);
            Controls.Add(pnlBestAsset);
            Controls.Add(pnlLeftNavigation);
            Controls.Add(panel4);
            Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Plus";
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            MouseDown += Dashboard_MouseDown;
            MouseMove += Dashboard_MouseMove;
            MouseUp += Dashboard_MouseUp;
            pnlBestAsset.ResumeLayout(false);
            pnlBestAsset.PerformLayout();
            pnlHighestExpense.ResumeLayout(false);
            pnlHighestExpense.PerformLayout();
            pnlTotalExpenseValue.ResumeLayout(false);
            pnlTotalExpenseValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chrtInvestment).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrtExpenses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeftNavigation;
        private Panel pnlBestAsset;
        private Panel pnlHighestExpense;
        private Panel pnlTotalExpenseValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label lblHighestExpense;
        private Label lblUserName;
        private Panel panel4;
        private Label lblHighestExpenseHeader;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtInvestment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtExpenses;
        private Label lblBestAsset;
        private Label lblTotalExpenses;
        private Button btnDashboardExitApp;
    }
}