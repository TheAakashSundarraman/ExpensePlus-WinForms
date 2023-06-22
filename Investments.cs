using ExpensePlus.BusinessLogic.Data;
using ExpensePlus.BusinessLogic.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpensePlus
{
    public partial class Investments : Form
    {
        private ExpensePlus.BusinessLogic.Data.Investments _investments;
        private DataSet chartData;
        private DataSet pieChartData;
        private AddInvestment addInvestment = new AddInvestment();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public User user { get; set; }
        public Investments() => InitializeComponent();

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dashboard(user).Show();
        }

        private void Investments_Load(object sender, EventArgs e)
        {
            var leftNavigation = new LeftNavigation();
            leftNavigation.User = user;
            leftNavigation.Dock = DockStyle.Fill;
            panel1.SuspendLayout();
            panel1.Controls.Clear();
            panel1.Controls.Add(leftNavigation);
            panel1.ResumeLayout();
            BindControls();
        }
        public void BindControls()
        {
            _investments = new ExpensePlus.BusinessLogic.Data.Investments(user);
            var ds = _investments.GetAllInvestmentsForUser();
            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Columns["Investment Amount"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Investment Date"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            dataGridView1.Columns["InvestmentID"].Visible = false;
            dataGridView1.Columns["InvestmentValue5"].Visible = false;
            dataGridView1.Columns["InvestmentValue10"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
            dataGridView1.Columns["InvestmentTypeID"].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Pink;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            dataGridView1.ScrollBars = ScrollBars.Both;
            ResizeColumns(dataGridView1);
            BuildInvestmentDropDown();
        }
        private void BuildInvestmentDropDown()
        {
            chartData = _investments.GetChartData();
            var cmbBoxListItems = chartData.Tables[0].AsEnumerable().Select(x => x.Field<string>("InvestName")).Distinct().ToList();
            cmbChartInvestments.DataSource = cmbBoxListItems;
            if (cmbChartInvestments.Items.Count != 0)
            {
                BuildChart(cmbChartInvestments.Items[0].ToString());
                BuildPiechart();
            }

        }
        private void ResizeColumns(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                int colw = dataGridView.Columns[i].Width;
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView.Columns[i].Width = colw;
            }
        }

        private void BuildChart(string InvestName)
        {
            int[]? filteredXValsData = null;
            decimal[]? filteredYValsData = null;
            filteredXValsData = chartData.Tables[0].AsEnumerable().Where(x => x.Field<string>("InvestName") == InvestName)
                                .Select(x => x.Field<int>("InvestmentProjectionYear")).ToArray();
            filteredYValsData = chartData.Tables[0].AsEnumerable().Where(x => x.Field<string>("InvestName") == InvestName)
                                .Select(x => x.Field<decimal>("ProjectionValue")).ToArray();
            // now iterate through the arrays to apply the points individually
            chart1.Series["InvestmentProjections"].Points.DataBindXY(filteredXValsData, filteredYValsData);

        }
        private void BuildPiechart()
        {
            pieChartData = _investments.GetPieChartData();
            var xValsData = pieChartData.Tables[0].AsEnumerable().Select(x => x.Field<string>("InvestName")).ToArray();
            var yValsData = pieChartData.Tables[0].AsEnumerable().Select(x => x.Field<decimal>("InvestmentAmount")).ToArray();
            chartPie.Series["PieSeries"].Points.DataBindXY(xValsData, yValsData);
        }


        private void cmbChartInvestments_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildChart(cmbChartInvestments.SelectedItem.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedInvestment = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => new BusinessLogic.Data.Investments()
            {
                InvestmentID = (Guid)x.Cells[0].Value,
                InvestmentName = x.Cells[1].Value.ToString(),
                InvestmentDate = DateTime.Parse(x.Cells[2].Value.ToString()),
                InvestmentAmount = (decimal)x.Cells[3].Value,
                InvestmentDescription = x.Cells[4].Value.ToString(),
                InvestmentTypeId = (int)x.Cells[8].Value,
                IsNew = false
            }).FirstOrDefault();
            if (selectedInvestment != null)
            {
                addInvestment._investments = selectedInvestment;
                addInvestment.user = user;
                addInvestment.ShowDialog(this);
            }
            else
                MessageBox.Show("Cannot add a new investment, please use Add Investment above!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedInvestment = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => new BusinessLogic.Data.Investments()
            {
                InvestmentID = (Guid)x.Cells[0].Value
            }).FirstOrDefault();
            if (_investments.DeleteExistingInvestment(selectedInvestment.InvestmentID, user.UserID))
                MessageBox.Show("Investment Deleted Successfully");
            else
                MessageBox.Show("Error occurred during deletion, please try again later!");
            BindControls();
        }

        private void btnAddInvestments_Click(object sender, EventArgs e)
        {
            this.Close();
            addInvestment.user = user;
            addInvestment.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInvestmentsExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Investments_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void Investments_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = MousePosition;
            dragFormPoint = this.Location;
        }

        private void Investments_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(MousePosition, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Investments_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
