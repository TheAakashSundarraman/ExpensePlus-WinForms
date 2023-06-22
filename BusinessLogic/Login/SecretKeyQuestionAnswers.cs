using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Windows.Networking;
using System.Data;

namespace ExpensePlus.BusinessLogic.Login
{
    public class SecretKeyQuestionAnswers
    {
        #region Public properties
        public int SecretKeyQuestionID { get; set; }
        public string SecretKeyQuestion { get; set; }
        public string SecretKeyAnswer { get; set; } 
        #endregion
        public bool AddSecretKeyQuestion(Guid userID)
        {
            bool isSecretKeyQuestion = false;
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spAddSecretKeyQuestions", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", userID);
                        sqlCommand.Parameters.AddWithValue("@SecretkeyQuestion", SecretKeyQuestion);
                        sqlCommand.Parameters.AddWithValue("@SecretKeyAnswer", Convert.ToBase64String(Encoding.UTF8.GetBytes(SecretKeyAnswer)));
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        isSecretKeyQuestion = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isSecretKeyQuestion;
        }
        public bool IsSecretAnswerCorrect(Guid userID, string secretKeyAnswer)
        {
            bool isSecretAnswer = false;
            if (secretKeyAnswer == SecretKeyAnswer) 
                isSecretAnswer = true;
            return isSecretAnswer;
        }
        public DataSet GetSecretKeyQuestionForuser(string Email)
        {
            DataSet dataSet = new DataSet();
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetSecretKeyQuestionsForUser", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Email", Email);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlConnection.Open();
                    sqlDataAdapter.Fill(dataSet);
                }
            }
            return dataSet;
        }
    }
}
