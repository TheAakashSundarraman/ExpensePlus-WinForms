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
    public partial class AddExpenses : Form
    {
        public BusinessLogic.Data.Expenses _expenses { get; set; }
        public User user { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public AddExpenses()
        {
            InitializeComponent();
        }

        private void lstNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddExpenses_Load(object sender, EventArgs e)
        {
            var leftNavigation = new LeftNavigation();
            leftNavigation.User = user;
            leftNavigation.Dock = DockStyle.Fill;
            pnlLeftNavigation.Controls.Add(leftNavigation);
            BindDropDown();
        }

        private void BindDropDown()
        {
            cmbExpenseType.DisplayMember = "ExpenseTypeName";
            cmbExpenseType.ValueMember = "ExpenseTypeID";
            cmbExpenseType.DataSource = new ExpenseType().GetAllExpenseTypes().Select(x => new { x.ExpenseTypeID, x.ExpenseTypeName }).ToList();
            btnAddModifyExpense.Text = "Add Expense";
            if (_expenses != null)
            {
                txtExpenseName.Text = _expenses.ExpenseName;
                txtExpenseAmount.Text = _expenses.ExpenseAmount.ToString();
                dtExpenseDate.Text = _expenses.ExpenseDate.ToString();
                txtExpenseDescription.Text = _expenses.ExpenseDescription;
                cmbExpenseType.SelectedValue = _expenses.ExpenseTypeID;
                lblCreateExpenseHeader.Text = "Modify Expense";
                btnAddModifyExpense.Text = "Modify Expense";
            }
        }

        private void btnAddModifyExpense_Click(object sender, EventArgs e)
        {
            if (_expenses == null)
                _expenses = new BusinessLogic.Data.Expenses(user);
            try
            {
                _expenses.ExpenseName = txtExpenseName.Text;
                _expenses.ExpenseDescription = txtExpenseDescription.Text;
                _expenses.ExpenseAmount = decimal.Parse(txtExpenseAmount.Text);
                _expenses.ExpenseTypeID = (int)cmbExpenseType.SelectedValue;
                _expenses.ExpenseDate = dtExpenseDate.Value;
                if (_expenses.AddExpenseForUser(user))
                {
                    MessageBox.Show("Expense added / updated successfully!");
                    ClearControls();
                }
                else
                    MessageBox.Show("Error occured during expense addition / updation, please try again!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured during expense addition / updation, please try again!");
            }
        }

        private void ClearControls()
        {
            txtExpenseName.Text = string.Empty;
            txtExpenseAmount.Text = string.Empty;
            txtExpenseDescription.Text = string.Empty;
            dtExpenseDate.Value = DateTime.Now;
            cmbExpenseType.SelectedIndex = 0;
        }

        private void AddExpenses_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void AddExpenses_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void AddExpenses_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AddExpenses_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
