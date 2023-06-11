namespace ExpensePlus
{
    partial class Investments
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Investments));
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            addInvestmentToolStripMenuItem = new ToolStripMenuItem();
            bndInvestments = new BindingSource(components);
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cmbChartInvestments = new ComboBox();
            lblInvestment = new Label();
            chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bndInvestments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(602, 710);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, addInvestmentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1399, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // addInvestmentToolStripMenuItem
            // 
            addInvestmentToolStripMenuItem.Name = "addInvestmentToolStripMenuItem";
            addInvestmentToolStripMenuItem.Size = new Size(127, 24);
            addInvestmentToolStripMenuItem.Text = "Add Investment";
            addInvestmentToolStripMenuItem.Click += addInvestmentToolStripMenuItem_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(621, 86);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "InvestmentProjections";
            series1.ToolTip = "#VALX{N} #VAL{C}";
            chart1.Series.Add(series1);
            chart1.Size = new Size(694, 330);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // cmbChartInvestments
            // 
            cmbChartInvestments.FormattingEnabled = true;
            cmbChartInvestments.Location = new Point(1177, 31);
            cmbChartInvestments.Name = "cmbChartInvestments";
            cmbChartInvestments.Size = new Size(121, 28);
            cmbChartInvestments.TabIndex = 3;
            cmbChartInvestments.SelectedIndexChanged += cmbChartInvestments_SelectedIndexChanged;
            // 
            // lblInvestment
            // 
            lblInvestment.AutoSize = true;
            lblInvestment.Location = new Point(966, 35);
            lblInvestment.Name = "lblInvestment";
            lblInvestment.Size = new Size(195, 20);
            lblInvestment.TabIndex = 4;
            lblInvestment.Text = "Choose an investment";
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            chartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartPie.Legends.Add(legend2);
            chartPie.Location = new Point(621, 422);
            chartPie.Name = "chartPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.LabelToolTip = "#VALX{N} #TOTAL{C}";
            series2.Legend = "Legend1";
            series2.Name = "PieSeries";
            series2.ToolTip = "#VALX{N} #VAL{C}";
            chartPie.Series.Add(series2);
            chartPie.Size = new Size(694, 381);
            chartPie.TabIndex = 5;
            chartPie.Text = "chart2";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(636, 31);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(728, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Investments
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1399, 759);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(chartPie);
            Controls.Add(lblInvestment);
            Controls.Add(cmbChartInvestments);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Investments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Investments";
            Load += Investments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bndInvestments).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private BindingSource bndInvestments;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ToolStripMenuItem addInvestmentToolStripMenuItem;
        private ComboBox cmbChartInvestments;
        private Label lblInvestment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private Button btnUpdate;
        private Button btnDelete;
    }
}