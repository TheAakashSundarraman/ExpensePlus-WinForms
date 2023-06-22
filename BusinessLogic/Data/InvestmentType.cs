using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensePlus.BusinessLogic.Data
{
    public class InvestmentType
    {
        #region public properties
        public int InvestmentTypeID { get; set; }
        public string InvestmentTypeName { get; set; }
        public string InvestmentTypeDescription { get; set; }
        #endregion
        #region public methods
        public DataSet GetAllInvestmentTypes()
        {
            DataSet investmentTypes = new DataSet();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllInvestmentType", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(investmentTypes);
                }
            }
            return investmentTypes;
        }
        #endregion
    }
}
