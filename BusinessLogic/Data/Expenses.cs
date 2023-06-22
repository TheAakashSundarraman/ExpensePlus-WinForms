using ExpensePlus.BusinessLogic.Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensePlus.BusinessLogic.Data
{
    public class Expenses : IExpenses
    {
        private readonly User user;
        public Expenses(User _user)
        {
            this.user = _user;
        }
        #region public properties
        public Guid ExpenseID { get; set; }
        public string ExpenseName { get; set; } = string.Empty;
        public string ExpenseDescription { get; set; } = string.Empty;
        public decimal ExpenseAmount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int ExpenseTypeID { get; set; }
        #endregion
        #region public methods
        public DataSet GetAllExpensesForUser()
        {
            DataSet expensesForUser = new DataSet();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllExpensesForUser", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@UserID", user.UserID);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(expensesForUser);
                }
            }
            return expensesForUser;
        }
        public bool AddExpenseForUser(User _user = null)
        {
            bool isExpenseAdded = false;
            try
            {
                if (ExpenseID != Guid.Empty)
                {
                    isExpenseAdded = UpdateExistingExpense(_user);
                }
                else
                {
                    isExpenseAdded = AddNewExpense();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isExpenseAdded;
        }
        public bool DeleteExistingExpense(Guid selectedExpenseID, Guid userID)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spDeleteExpenseForUser", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", userID);
                        sqlCommand.Parameters.AddWithValue("@ExpenseID", selectedExpenseID);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public DataSet GetExpensePieChartData()
        {
            DataSet chartData = new DataSet();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetExpensePieChart", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@UserID", user.UserID);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(chartData);
                }
            }
            return chartData;
        }
        #endregion
        #region private methods
        private bool UpdateExistingExpense(User _user)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spUpdateExpensesForUser", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", _user.UserID);
                        sqlCommand.Parameters.AddWithValue("@ExpenseID", ExpenseID);
                        sqlCommand.Parameters.AddWithValue("@ExpenseName", ExpenseName);
                        sqlCommand.Parameters.AddWithValue("@ExpenseDate", ExpenseDate);
                        sqlCommand.Parameters.AddWithValue("@ExpenseAmount", ExpenseAmount);
                        sqlCommand.Parameters.AddWithValue("@ExpenseDescription", ExpenseDescription);
                        sqlCommand.Parameters.AddWithValue("@ExpenseTypeID", ExpenseTypeID);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        private bool AddNewExpense()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spAddExpenseForUser", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", user.UserID);
                        sqlCommand.Parameters.AddWithValue("@ExpenseID", Guid.NewGuid());
                        sqlCommand.Parameters.AddWithValue("@ExpenseName", ExpenseName);
                        sqlCommand.Parameters.AddWithValue("@ExpenseDate", ExpenseDate);
                        sqlCommand.Parameters.AddWithValue("@ExpenseAmount", ExpenseAmount);
                        sqlCommand.Parameters.AddWithValue("@ExpenseDescription", ExpenseDescription);
                        sqlCommand.Parameters.AddWithValue("@ExpenseTypeID", ExpenseTypeID);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        #endregion
    }
}
