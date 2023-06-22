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
    public partial class Reports : Form
    {
        public User user { get; set; }
        public DataSet dsInvestments { get; set; }
        public DataSet dsExpenses { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Reports()
        {
            InitializeComponent();
        }
        public Reports(User _user)
        {
            user = _user;
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            var leftNavigation = new LeftNavigation();
            leftNavigation.User = user;
            pnlLeftNavigation.Controls.Add(leftNavigation);
            leftNavigation.Dock = DockStyle.Fill;
            BindControl();
        }

        private void BindControl()
        {
            var investments = new BusinessLogic.Data.Investments(user);
            dsInvestments = investments.GetAllInvestmentsForUser();
            dgInvestments.AutoGenerateColumns = true;
            dgInvestments.DataSource = dsInvestments;
            dgInvestments.DataMember = dsInvestments.Tables[0].TableName;
            dgInvestments.MultiSelect = false;
            dgInvestments.AllowUserToResizeColumns = true;
            dgInvestments.AllowUserToOrderColumns = true;
            dgInvestments.Columns["InvestmentID"].Visible = false;
            dgInvestments.Columns["InvestmentValue5"].Visible = false;
            dgInvestments.Columns["InvestmentValue10"].Visible = false;
            dgInvestments.Columns["UserID"].Visible = false;
            dgInvestments.Columns["InvestmentTypeID"].Visible = false;
            dgInvestments.Columns["Investment Amount"].DefaultCellStyle.Format = "C2";
            dgInvestments.Columns["Investment Date"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            dgInvestments.ColumnHeadersDefaultCellStyle.BackColor = Color.Pink;
            dgInvestments.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgInvestments.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgInvestments.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            dgInvestments.EnableHeadersVisualStyles = false;
            var expenses = new BusinessLogic.Data.Expenses(user);
            dsExpenses = expenses.GetAllExpensesForUser();
            dgExpenses.AutoGenerateColumns = true;
            dgExpenses.AutoSize = true;
            dgExpenses.DataSource = dsExpenses;
            dgExpenses.DataMember = dsExpenses.Tables[0].TableName;
            dgExpenses.MultiSelect = false;
            dgExpenses.AllowUserToOrderColumns = true;
            dgExpenses.AllowUserToResizeColumns = true;
            dgExpenses.Columns["ExpenseID"].Visible = false;
            dgExpenses.Columns["ExpenseTypeID"].Visible = false;
            dgExpenses.Columns["Expense Amount"].DefaultCellStyle.Format = "C2";
            dgExpenses.Columns["Expense Date"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            dgExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.Pink;
            dgExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgExpenses.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgExpenses.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            dgExpenses.EnableHeadersVisualStyles = false;

        }

        private void btnExportInvstmentToCSV_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = dsInvestments.Tables[0].Columns.Cast<DataColumn>().Select(x => x.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));
            foreach (DataRow row in dsInvestments.Tables[0].Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                sb.AppendLine(string.Join(",", fields));
            }
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "*.csv|*.csv";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, sb.ToString());
                }
            }
        }

        private void btnExportExpensestoCSV_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = dsExpenses.Tables[0].Columns.Cast<DataColumn>().Select(x => x.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));
            foreach (DataRow row in dsExpenses.Tables[0].Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                sb.AppendLine(string.Join(",", fields));
            }
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "*.csv|*.csv";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, sb.ToString());
                }
            }
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void Reports_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Reports_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Reports_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
