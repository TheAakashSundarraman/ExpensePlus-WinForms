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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Investments));
            dataGridView1 = new DataGridView();
            bndInvestments = new BindingSource(components);
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cmbChartInvestments = new ComboBox();
            lblInvestment = new Label();
            chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblGridFunctions = new Label();
            btnAddInvestments = new Button();
            btnInvestmentsExitApp = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bndInvestments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1136, 325);
            dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(256, 53);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "InvestmentProjections";
            series1.ToolTip = "#VALX{N} #VAL{C}";
            chart1.Series.Add(series1);
            chart1.Size = new Size(628, 330);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // cmbChartInvestments
            // 
            cmbChartInvestments.FormattingEnabled = true;
            cmbChartInvestments.Location = new Point(479, 15);
            cmbChartInvestments.Name = "cmbChartInvestments";
            cmbChartInvestments.Size = new Size(121, 28);
            cmbChartInvestments.TabIndex = 3;
            cmbChartInvestments.SelectedIndexChanged += cmbChartInvestments_SelectedIndexChanged;
            // 
            // lblInvestment
            // 
            lblInvestment.AutoSize = true;
            lblInvestment.Location = new Point(268, 19);
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
            chartPie.Location = new Point(885, 58);
            chartPie.Name = "chartPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.LabelToolTip = "#VALX{N} #TOTAL{C}";
            series2.Legend = "Legend1";
            series2.Name = "PieSeries";
            series2.ToolTip = "#VALX{N} #VAL{C}";
            chartPie.Series.Add(series2);
            chartPie.Size = new Size(508, 325);
            chartPie.TabIndex = 5;
            chartPie.Text = "chart2";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Location = new Point(422, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(532, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 806);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(269, 408);
            panel2.Name = "panel2";
            panel2.Size = new Size(1136, 325);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblGridFunctions);
            panel3.Controls.Add(btnAddInvestments);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDelete);
            panel3.Location = new Point(623, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(659, 52);
            panel3.TabIndex = 10;
            // 
            // lblGridFunctions
            // 
            lblGridFunctions.AutoSize = true;
            lblGridFunctions.Location = new Point(19, 15);
            lblGridFunctions.Name = "lblGridFunctions";
            lblGridFunctions.Size = new Size(131, 20);
            lblGridFunctions.TabIndex = 9;
            lblGridFunctions.Text = "Grid Functions";
            // 
            // btnAddInvestments
            // 
            btnAddInvestments.BackColor = Color.Violet;
            btnAddInvestments.Location = new Point(224, 11);
            btnAddInvestments.Name = "btnAddInvestments";
            btnAddInvestments.Size = new Size(166, 29);
            btnAddInvestments.TabIndex = 8;
            btnAddInvestments.Text = "Add Investments";
            btnAddInvestments.UseVisualStyleBackColor = false;
            btnAddInvestments.Click += btnAddInvestments_Click;
            // 
            // btnInvestmentsExitApp
            // 
            btnInvestmentsExitApp.BackColor = Color.Red;
            btnInvestmentsExitApp.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvestmentsExitApp.ForeColor = Color.White;
            btnInvestmentsExitApp.Location = new Point(1375, 11);
            btnInvestmentsExitApp.Name = "btnInvestmentsExitApp";
            btnInvestmentsExitApp.Size = new Size(30, 29);
            btnInvestmentsExitApp.TabIndex = 12;
            btnInvestmentsExitApp.Text = "X";
            btnInvestmentsExitApp.UseVisualStyleBackColor = false;
            btnInvestmentsExitApp.Click += btnInvestmentsExitApp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 375);
            label1.Name = "label1";
            label1.Size = new Size(491, 20);
            label1.TabIndex = 13;
            label1.Text = "Note*: Not Financial Advice. Based on 5% market average";
            label1.Click += label1_Click;
            // 
            // Investments
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 806);
            Controls.Add(label1);
            Controls.Add(btnInvestmentsExitApp);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(chartPie);
            Controls.Add(lblInvestment);
            Controls.Add(cmbChartInvestments);
            Controls.Add(chart1);
            Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Investments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Investments";
            FormClosing += Investments_FormClosing;
            Load += Investments_Load;
            MouseDown += Investments_MouseDown;
            MouseMove += Investments_MouseMove;
            MouseUp += Investments_MouseUp;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bndInvestments).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bndInvestments;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ComboBox cmbChartInvestments;
        private Label lblInvestment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnAddInvestments;
        private Label lblGridFunctions;
        private Button btnInvestmentsExitApp;
        private Label label1;
    }
}