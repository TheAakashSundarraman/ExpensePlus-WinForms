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

namespace ExpensePlus
{
    public partial class Expenses : Form
    {
        public User user { get; set; }
        private BusinessLogic.Data.Expenses expenses;
        private DataSet chartData;
        private AddExpenses addnewExpense = new AddExpenses();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Expenses()
        {
            InitializeComponent();
        }
        public Expenses(User _user)
        {
            user = _user;
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            var leftNavigation = new LeftNavigation();
            leftNavigation.User = user;
            tableLayoutPanel1.Controls.Add(leftNavigation);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            BindControl();
        }

        public void BindControl()
        {
            expenses = new BusinessLogic.Data.Expenses(user);
            var ds = expenses.GetAllExpensesForUser();
            dgExpenses.AutoGenerateColumns = true;
            dgExpenses.AutoSize = true;
            dgExpenses.DataSource = ds;
            dgExpenses.DataMember = ds.Tables[0].TableName;
            dgExpenses.MultiSelect = false;
            dgExpenses.AllowUserToOrderColumns = true;
            dgExpenses.AllowUserToResizeColumns = true;
            dgExpenses.Columns["ExpenseID"].Visible = false;
            dgExpenses.Columns["ExpenseTypeID"].Visible = false;
            dgExpenses.ScrollBars = ScrollBars.Both;
            dgExpenses.Columns["Expense Amount"].DefaultCellStyle.Format = "C2";
            dgExpenses.Columns["Expense Date"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            dgExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.Pink;
            dgExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgExpenses.EnableHeadersVisualStyles = false;
            dgExpenses.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgExpenses.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            ResizeColumns(dgExpenses);
            dgExpenses.Dock = DockStyle.Fill;
            var highestExpense = ds.Tables[0].AsEnumerable().OrderByDescending(x => x.Field<decimal>("Expense Amount"))
                .Select(x => x.Field<decimal>("Expense Amount")).FirstOrDefault();
            lblHighestExpense.Text = highestExpense.ToString();
            var mostFRequentExpense = ds.Tables[0].AsEnumerable()
                .GroupBy(x => x.Field<string>("Expense Name")).OrderByDescending(x => x.Count()).Take(1).Select(x => x.Key).FirstOrDefault();
            if (mostFRequentExpense != null)
                lblMostFrequent.Text = mostFRequentExpense.ToString();
            if (highestExpense == 0)
            {
                lblHighestExpense.Visible= false;
            }
            if (mostFRequentExpense == null)
            {
                lblMostFrequent.Visible= false;
            }
            BindChart(expenses);
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

        private void BindChart(BusinessLogic.Data.Expenses expenses)
        {
            DataSet chartData = expenses.GetExpensePieChartData();
            var sortedData = chartData.Tables[0].AsEnumerable()
                .Select(x => new { ExpenseName = x.Field<string>("ExpenseName"), ExpenseAmount = x.Field<decimal>("ExpenseAmount") })
                .GroupBy(x => new { x.ExpenseName, x.ExpenseAmount })
                .OrderByDescending(x => x.Sum(y => y.ExpenseAmount))
                .Select(x => new { x.Key.ExpenseName, x.Key.ExpenseAmount }).ToList();
            var xValsData = sortedData.Select(x => x.ExpenseName).ToList();
            var yValsData = sortedData.Select(x => Math.Round(x.ExpenseAmount, 2)).ToList();
            chrtExpenses.Series["funnelSeries"].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending);
            chrtExpenses.Series["funnelSeries"].Points.DataBindXY(xValsData, yValsData);

        }

        private void btnAddNewExpense_Click(object sender, EventArgs e)
        {
            this.Close();
            addnewExpense.user = user;
            addnewExpense.ShowDialog(this);
        }

        private void btnUpdateExpenses_Click(object sender, EventArgs e)
        {
            var selectedExpense = dgExpenses.SelectedRows.Cast<DataGridViewRow>().Select(x =>
            {
                return new BusinessLogic.Data.Expenses(user)
                {
                    ExpenseID = (Guid)x.Cells[0].Value,
                    ExpenseName = x.Cells[1].Value.ToString(),
                    ExpenseDescription = x.Cells[3].Value.ToString(),
                    ExpenseDate = DateTime.Parse(x.Cells[4].Value.ToString()),
                    ExpenseAmount = (decimal)x.Cells[5].Value,
                    ExpenseTypeID = (int)x.Cells[6].Value
                };
            }).FirstOrDefault();
            if (selectedExpense != null)
            {
                addnewExpense._expenses = selectedExpense;
                addnewExpense.user = user;
                addnewExpense.ShowDialog(this);
            }
            else
                MessageBox.Show("Cannot update an existing expense, please try again later!");
        }

        private void btnDeleteExpenses_Click(object sender, EventArgs e)
        {
            var selectedExpense = dgExpenses.SelectedRows.Cast<DataGridViewRow>().Select(x =>
            {
                return new BusinessLogic.Data.Expenses(user)
                {
                    ExpenseID = (Guid)x.Cells[0].Value
                };
            }).FirstOrDefault();
            if (expenses.DeleteExistingExpense(selectedExpense.ExpenseID, user.UserID))
            {
                MessageBox.Show("Expense Deleted succesfully!");
                BindControl();
            }
            else
                MessageBox.Show("Something went wrong, please try again later!");
        }

        private void btnExpensesExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Expenses_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void Expenses_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Expenses_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Expenses_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
