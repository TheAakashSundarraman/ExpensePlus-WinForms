using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensePlus.BusinessLogic.Login
{
    public class Role
    {
        #region public properties
        public string RoleID { get; set; }
        public string RoleType { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        #endregion
        #region Public Methods
        public DataTable GetAllRoles()
        {
            DataTable roleDataTable = new DataTable();
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetAllRoles", sqlConnection);
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        sqlDataAdapter.Fill(roleDataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return roleDataTable;
        } 
        #endregion
    }
}
