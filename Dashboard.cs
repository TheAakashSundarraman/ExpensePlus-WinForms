using ExpensePlus.BusinessLogic.Data;
using ExpensePlus.BusinessLogic.Login;
using Microsoft.VisualBasic.Logging;
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
using Windows.Gaming.Input.ForceFeedback;
using Windows.Networking.Vpn;
using YahooFinanceApi;

namespace ExpensePlus
{
    public partial class Dashboard : Form
    {
        public User User { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public ToolTip ToolTip { get; set; }
        public Dashboard() 
        { 
            InitializeComponent();
            ToolTip = new ToolTip();
        }
        public Dashboard(User user)
        {
            User = user;
        }


        private void CloseApplication()
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            BindControls();
        }
        public void BindControls()
        {
            var leftNavigation = new LeftNavigation
            {
                User = User,
                Width = 250,
                Height = 592
            };
            leftNavigation.User = User;
            pnlLeftNavigation.Controls.Add(leftNavigation);
            leftNavigation.Dock = DockStyle.Fill;
            lblUserName.Text = string.Format("Hello {0}", User.FirstName);
            BindStockInformationChart();
            BindInvestmenttoExpenseChart();
        }
        private async void BindStockInformationChart()
        {
            try
            {
                var investments = new BusinessLogic.Data.Investments(User);
                var stockNames = investments.GetStockNamesForUser(User);
                List<Stock> stockSymbols = investments.GetStockInformationFromNasdaq();
                string series = "StockSeries";
                Random rnd = new Random();
                chart1.Series.RemoveAt(0);
                chart1.ChartAreas.RemoveAt(0);
                var chartArea = chart1.ChartAreas.Add("NewChartArea");
                //var chartArea3dStyle = new ChartArea3DStyle();
                //chartArea3dStyle.Enable3D = true;
                //chartArea3dStyle.IsClustered = true;
                //chartArea.Area3DStyle = chartArea3dStyle;
                foreach (var stockItem in stockNames)
                {
                    Color randomColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    var stockSymbol = stockSymbols.Where(x => x.StockSymbol.Contains(stockItem)).FirstOrDefault();
                    if (stockSymbol != null)
                    {
                        Series chartSeries = new Series(stockSymbol.StockSymbol);
                        chartSeries.ChartType = SeriesChartType.Line;
                        chartSeries.AxisLabel = stockSymbol.StockName;
                        if (!chart1.Series.Any(x => x.Name == chartSeries.Name))
                            chart1.Series.Add(chartSeries);
                        Series chartLowSeries = new Series(stockSymbol.StockSymbol + "-low");
                        chartLowSeries.ChartType = SeriesChartType.Line;
                        chartLowSeries.AxisLabel = stockSymbol.StockName;
                        if (!chart1.Series.Any(x => x.Name == chartLowSeries.Name))
                            chart1.Series.Add(chartLowSeries);
                        Yahoo.IgnoreEmptyRows = true;
                        DateTime startDateTime = DateTime.Now.AddYears(-1);
                        var firstStockHistory = await Yahoo.GetHistoricalAsync(stockSymbol.StockSymbol, startDateTime, DateTime.Now, Period.Monthly);
                        int mthCounter = 0;
                        foreach (var item in firstStockHistory)
                        {
                            string startDatetimebyMonth = startDateTime.AddMonths(mthCounter).ToString("dd-MM-yyyy");
                            chartSeries.YValueMembers = item.High.ToString();
                            chartSeries.Color = randomColor;
                            chartSeries.ToolTip = item.High.ToString();
                            chart1.Series[chartSeries.Name].Points.AddXY(startDatetimebyMonth, item.High);
                            chartLowSeries.YValueMembers = item.Low.ToString();
                            chartLowSeries.Color = Color.Red;
                            chartLowSeries.ToolTip = stockSymbol.StockName + " - Low -" + item.Low.ToString();
                            chart1.Series[chartLowSeries.Name].Points.AddXY(startDatetimebyMonth, item.Low);
                            mthCounter++;
                        }
                    }
                }
                var investmentProjections = investments.GetChartData();
                lblBestAsset.Text = investmentProjections.Tables[0].AsEnumerable()
                                    .OrderByDescending(x => x.Field<decimal>("ProjectionValue"))
                                    .Select(x => x.Field<string>("InvestName")).FirstOrDefault();

                lblBestAsset.Visible = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured during yahoo API fetching");
                lblBestAsset.Visible = false;
            }
        }
        private void BindInvestmenttoExpenseChart()
        {
            var pieChartData = new BusinessLogic.Data.Investments(User).GetPieChartData();
            var xValsData = pieChartData.Tables[0].AsEnumerable().Select(x => x.Field<string>("InvestName")).ToArray();
            var yValsData = pieChartData.Tables[0].AsEnumerable().Select(x => x.Field<decimal>("InvestmentAmount")).ToArray();
            chrtInvestment.Series["DonutSeries"].Points.DataBindXY(xValsData, yValsData);
            chrtInvestment.Series["DonutSeries"].ToolTip = string.Format("Investment: #VALX, #VAL");
            DataSet chartData = new BusinessLogic.Data.Expenses(User).GetExpensePieChartData();
            if (chartData.Tables[0].Rows.Count > 0)
            {
                var sortedData = chartData.Tables[0].AsEnumerable()
                    .Select(x => new { ExpenseName = x.Field<string>("ExpenseName"), ExpenseAmount = x.Field<decimal>("ExpenseAmount") })
                    .GroupBy(x => new { x.ExpenseName, x.ExpenseAmount })
                    .OrderByDescending(x => x.Sum(y => y.ExpenseAmount))
                    .Select(x => new { x.Key.ExpenseName, x.Key.ExpenseAmount }).ToList();
                var xData = sortedData.Select(x => x.ExpenseName).ToList();
                var yData = sortedData.Select(x => Math.Round(x.ExpenseAmount, 2)).ToList();
                chrtExpenses.Series["DonutSeries"].Points.DataBindXY(xData, yData);
                chrtExpenses.Series["DonutSeries"].ToolTip = string.Format("Expense: #VALX, #VAL");
                lblHighestExpense.Text = chartData.Tables[0]
                    .AsEnumerable()
                    .OrderByDescending(x => x.Field<decimal>("ExpenseAmount"))
                    .Select(x => x.Field<string>("ExpenseName"))
                    .FirstOrDefault()
                    .ToString();
                lblTotalExpenses.Text = chartData.Tables[0].AsEnumerable()
                                        .Sum(x => x.Field<decimal>("ExpenseAmount")).ToString();
                chrtInvestment.Titles.Add("Investments");
                chrtExpenses.Titles.Add("Expenses");
            }
            else
            {
                lblHighestExpense.Visible = false;
                lblBestAsset.Visible = false;
                lblTotalExpenses.Visible = false;
            }
        }

        private void chrtInvestment_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboardExitApp_Click(object sender, EventArgs e)
        {
            foreach (var p in System.Diagnostics.Process.GetProcessesByName("ExpensePlus"))
            {
                p.Kill();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = MousePosition;
            dragFormPoint = this.Location;
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(MousePosition, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void lblBestAsset_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Based on investment projections computations and not yahoo financial information", this);
        }
    }
}
