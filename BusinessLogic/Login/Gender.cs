using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensePlus.BusinessLogic.Login
{
    public class Gender
    {
        #region public properties
        public int GenderID { get; set; }
        public string? GenderName { get; set; }
        #endregion
        private DataTable genderDataTable = new DataTable();
        #region public methods
        public DataTable GetAllGender()
        {   
            try
            {
                using(var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetAllGender", sqlConnection);
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        sqlDataAdapter.Fill(genderDataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return genderDataTable;
        }
        public int GetGenderIDbyValue(string value)
        {
            try
            {
                if (genderDataTable != null)
                {
                    foreach (DataRow item in genderDataTable.Rows)
                    {
                        if (item[1].ToString() == value)
                            return (int)item[0];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        #endregion
    }
}
