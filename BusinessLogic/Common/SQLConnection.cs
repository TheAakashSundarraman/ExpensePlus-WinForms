using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensePlus.BusinessLogic.Common
{
    public static class SQLConnection
    {
        #region public properties
        public static string DatabaseConnection { get; set; } = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        #endregion
    }
}
