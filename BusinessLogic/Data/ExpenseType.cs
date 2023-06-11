using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensePlus.BusinessLogic.Data
{
    public class ExpenseType
    {
        #region public properties
        public int ExpenseTypeID { get; set; }
        public string ExpenseTypeName { get; set; }
        public string ExpenseTypeDescription { get; set; }
        #endregion
        #region public methods
        public List<ExpenseType> GetAllExpenseTypes()
        {
            List<ExpenseType> expenseTypes = new List<ExpenseType>();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllExpenseTypes", sqlConnection))
                {
                    DataTable dt = new DataTable();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    expenseTypes = dt.AsEnumerable().Select(x =>
                        new ExpenseType()
                        {
                            ExpenseTypeID = x.Field<int>("ExpenseTypeID"),
                            ExpenseTypeName = x.Field<string>("ExpenseTypeName")
                        }
                    ).ToList();
                }
            }
            return expenseTypes;
        }
        #endregion
    }
}
