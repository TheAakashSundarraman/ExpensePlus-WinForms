using ExpensePlus.BusinessLogic.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensePlus.BusinessLogic.Data
{
    public class Expenses
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

    }
}
