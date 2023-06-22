using ExpensePlus.BusinessLogic.Login;
using System.Data;

namespace ExpensePlus.BusinessLogic.Data
{
    public interface IInvestments
    {
        decimal InvestmentAmount { get; set; }
        DateTime InvestmentDate { get; set; }
        string InvestmentDescription { get; set; }
        Guid InvestmentID { get; set; }
        string InvestmentName { get; set; }
        int InvestmentTypeId { get; set; }
        decimal InvestmentValue10 { get; set; }
        decimal InvestmentValue5 { get; set; }

        bool AddInvestmentForUser(User _user = null);
        DataSet CheckInvstmentAlreadyExists(Guid InvestmentID);
        bool DeleteExistingInvestment(Guid selectedInvestmentID, Guid userID);
        DataSet GetAllInvestmentsForUser();
        DataSet GetChartData();
        DataSet GetPieChartData();
        void UpdateInvestmentProjection(int currentYear, decimal projectionValue, DataSet existingInvestmentProjections);
    }
}