using ExpensePlus.BusinessLogic.Login;
using System.Data;

namespace ExpensePlus.BusinessLogic.Data
{
    public interface IExpenses
    {
        decimal ExpenseAmount { get; set; }
        DateTime ExpenseDate { get; set; }
        string ExpenseDescription { get; set; }
        Guid ExpenseID { get; set; }
        string ExpenseName { get; set; }
        int ExpenseTypeID { get; set; }

        bool AddExpenseForUser(User _user = null);
        bool DeleteExistingExpense(Guid selectedExpenseID, Guid userID);
        DataSet GetAllExpensesForUser();
        DataSet GetExpensePieChartData();
    }
}