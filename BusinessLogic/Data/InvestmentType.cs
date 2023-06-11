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
        public List<InvestmentType> GetAllInvestmentTypes()
        {
            List<InvestmentType> investmentTypes = new List<InvestmentType>();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetAllInvestmentType", sqlConnection))
                {
                    DataTable dt = new DataTable();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    investmentTypes = dt.AsEnumerable().Select(x =>
                        new InvestmentType()
                        {
                            InvestmentTypeID = x.Field<int>("InvestmentTypeID"),
                            InvestmentTypeName = x.Field<string>("InvestmentTypeName")
                        }
                    ).ToList();
                }
            }
            return investmentTypes;
        }
        #endregion
    }
}
