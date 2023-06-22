using ExpensePlus.BusinessLogic.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Windows.Networking;
using System.Configuration;

namespace ExpensePlus.BusinessLogic.Data
{
    public class Investments : IInvestments
    {
        private readonly User user;

        #region Constructors
        public Investments()
        {

        }
        public Investments(User user)
        {
            this.user = user;
        }
        #endregion
        #region public properties
        public Guid InvestmentID { get; set; }
        public string InvestmentName { get; set; }
        public int InvestmentTypeId { get; set; }
        public DateTime InvestmentDate { get; set; }
        public decimal InvestmentAmount { get; set; }
        public string InvestmentDescription { get; set; }
        public decimal InvestmentValue5 { get; set; }
        public decimal InvestmentValue10 { get; set; }
        public bool IsNew { get; set; }
        #endregion
        public DataSet GetAllInvestmentsForUser()
        {
            DataSet investmentForUser = new DataSet();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetInvestmentForUser", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@UserID", user.UserID);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(investmentForUser);
                }
            }
            return investmentForUser;
        }
        public DataSet GetChartData()
        {
            DataSet chartData = new DataSet();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetInvestmentProjectionsForUser", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@UserID", user.UserID);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(chartData);
                }
            }
            return chartData;
        }
        public DataSet GetPieChartData()
        {
            DataSet chartData = new DataSet();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetPiechartValuesforUser", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@UserID", user.UserID);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(chartData);
                }
            }
            return chartData;
        }
        public DataSet CheckInvstmentAlreadyExists(Guid InvestmentID)
        {
            DataSet existingInvestmentProjection = new DataSet();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetInvestmentProjectionForInvestmentID", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@InvestmentID", InvestmentID);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(existingInvestmentProjection);
                }
            }
            return existingInvestmentProjection;
        }
        public bool AddInvestmentForUser(User _user = null)
        {
            bool isInvestmentAdded = false;
            try
            {
                if (!IsNew)
                {
                    isInvestmentAdded = UpdateExistingInvestment(_user);
                }
                else
                {
                    isInvestmentAdded = AddNewInvestment();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isInvestmentAdded;
        }
        private bool UpdateExistingInvestment(User _user)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    decimal intrestRate = decimal.Parse(System.Configuration.ConfigurationManager.AppSettings["AnnualIntrestRate"]);
                    decimal investmentValue5 = GetInvestmentProjectionValue(InvestmentAmount, intrestRate, 5);
                    decimal investmentValue10 = GetInvestmentProjectionValue(InvestmentAmount, intrestRate, 10);
                    using (SqlCommand sqlCommand = new SqlCommand("spUpdateInvestmentForUser", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", _user.UserID);
                        sqlCommand.Parameters.AddWithValue("@InvestmentID", InvestmentID);
                        sqlCommand.Parameters.AddWithValue("@InvestName", this.InvestmentName);
                        sqlCommand.Parameters.AddWithValue("@InvestmentDate", this.InvestmentDate);
                        sqlCommand.Parameters.AddWithValue("@InvestmentAmount", this.InvestmentAmount);
                        sqlCommand.Parameters.AddWithValue("@InvestmentDescription", this.InvestmentDescription);
                        sqlCommand.Parameters.AddWithValue("@InvestmentTypeID", this.InvestmentTypeId);
                        sqlCommand.Parameters.AddWithValue("@InvestmentValue5", investmentValue5);
                        sqlCommand.Parameters.AddWithValue("@InvestmentValue10", investmentValue10);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        ComputeInvestmentProjections(InvestmentID);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public bool DeleteExistingInvestment(Guid selectedInvestmentID, Guid userID)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spDeleteInvestment", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", userID);
                        sqlCommand.Parameters.AddWithValue("@InvestmentID", selectedInvestmentID);
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
        public List<string> GetStockNamesForUser(User user)
        {
            List<string> stockNames = new List<string>();
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spGetAllStockNamesForUser", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", user.UserID);
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.HasRows && reader.GetValue(0) != null)
                            {
                                stockNames.Add(reader.GetValue(0).ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured during fetching stock names");
            }

            return stockNames;

        }
        public List<Stock> GetStockInformationFromNasdaq()
        {
            var csvLines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Database\\nasdaq_stock_data.csv");
            var csvLinesData = csvLines.Skip(1).Select(x => x.Split(',')).ToArray();
            var stockMasterList = csvLinesData.Select(x => new Stock() { StockSymbol = x[0], StockName = x[1] }).ToList();
            return stockMasterList;
        }
        private bool AddNewInvestment()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spAddInvestmentForUser", sqlConnection))
                    {
                        decimal intrestRate = decimal.Parse(System.Configuration.ConfigurationManager.AppSettings["AnnualIntrestRate"]);
                        decimal investmentValue5 = GetInvestmentProjectionValue(InvestmentAmount, intrestRate, 5);
                        decimal investmentValue10 = GetInvestmentProjectionValue(InvestmentAmount, intrestRate, 10);
                        InvestmentID = Guid.NewGuid();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", user.UserID);
                        sqlCommand.Parameters.AddWithValue("@InvestmentID", InvestmentID);
                        sqlCommand.Parameters.AddWithValue("@InvestmentName", this.InvestmentName);
                        sqlCommand.Parameters.AddWithValue("@InvestmentDate", this.InvestmentDate);
                        sqlCommand.Parameters.AddWithValue("@InvestmentAmount", this.InvestmentAmount);
                        sqlCommand.Parameters.AddWithValue("@InvestmentDescription", this.InvestmentDescription);
                        sqlCommand.Parameters.AddWithValue("@InvestmentTypeID", this.InvestmentTypeId);
                        sqlCommand.Parameters.AddWithValue("@InvestmentValue5", investmentValue5);
                        sqlCommand.Parameters.AddWithValue("@InvestmentValue10", investmentValue10);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        ComputeInvestmentProjections(InvestmentID);
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
        private decimal GetInvestmentProjectionValue(decimal InvestmentAmount, decimal intrestRate, int numberOfYears = 0)
        {
            decimal investmentProjectionValue = 0;
            switch (numberOfYears)
            {
                case 0:
                    investmentProjectionValue = InvestmentAmount * (1 + (intrestRate / 100));
                    break;
                default:
                    for (int i = 0; i < numberOfYears; i++)
                    {
                        decimal projectionValue = 0;
                        projectionValue = InvestmentAmount * (1 + (intrestRate / 100));
                        InvestmentAmount = projectionValue;
                    }
                    investmentProjectionValue = InvestmentAmount;
                    break;
            }
            return investmentProjectionValue;
        }
        private void ComputeInvestmentProjections(Guid investmentID)
        {
            int numberofYearstoComputeInvestmentProjection = int.Parse(ConfigurationManager.AppSettings["NumberofYearstoComputeInvestmentProjection"]);
            int currentYear = DateTime.Now.Year;
            decimal intrestRate = decimal.Parse(ConfigurationManager.AppSettings["AnnualIntrestRate"]);
            DataSet existingInvestmentProjections = CheckInvstmentAlreadyExists(InvestmentID);
            if (existingInvestmentProjections.Tables[0].Rows.Count == 0)
            {
                for (int i = 0; i < numberofYearstoComputeInvestmentProjection; i++)
                {
                    decimal projectionValue = GetInvestmentProjectionValue(InvestmentAmount, intrestRate);
                    AddInvestmentProjection(currentYear, projectionValue);
                    InvestmentAmount = projectionValue;
                    currentYear++;
                }

            }
            else
            {
                for (int i = 0; i < numberofYearstoComputeInvestmentProjection; i++)
                {
                    decimal projectionValue = GetInvestmentProjectionValue(InvestmentAmount, intrestRate);
                    UpdateInvestmentProjection(currentYear, projectionValue, existingInvestmentProjections);
                    InvestmentAmount = projectionValue;
                    currentYear++;
                }

            }
        }
        private void AddInvestmentProjection(int currentYear, decimal projectionValue)
        {
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spAddInvestmentProjections", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@InvestmentprojectionID", Guid.NewGuid());
                    sqlCommand.Parameters.AddWithValue("@InvestmentID", InvestmentID);
                    sqlCommand.Parameters.AddWithValue("@InvestmentProjectionYear", currentYear);
                    sqlCommand.Parameters.AddWithValue("@InvestmentProjectionValue", projectionValue);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateInvestmentProjection(int currentYear, decimal projectionValue, DataSet existingInvestmentProjections)
        {
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spUpdateInvestmentProjectionsForUser", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@InvestmentID", InvestmentID);
                    sqlCommand.Parameters.AddWithValue("@InvestmentProjectionYear", currentYear);
                    sqlCommand.Parameters.AddWithValue("@InvestmentProjectionValue", projectionValue);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
