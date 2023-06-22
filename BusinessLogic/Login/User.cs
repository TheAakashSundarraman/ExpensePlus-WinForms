using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExpensePlus.BusinessLogic.Login
{
    public class User : SecretKeyQuestionAnswers, IUser
    {
        #region Public properties
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateofBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleID { get; set; }
        public int GenderID { get; set; }
        #endregion
        #region public methods
        public User GetUserByEmail(string Email)
        {
            User user = null;
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("spGetUserByEmail", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Email", Email);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        user = new User()
                        {
                            UserID = Guid.Parse(sqlDataReader["UserID"].ToString()),
                            FirstName = sqlDataReader["FirstName"].ToString(),
                            LastName = sqlDataReader["LastName"].ToString(),
                            PhoneNumber = sqlDataReader["Phonenumber"].ToString(),
                            Email = sqlDataReader["Email"].ToString(),
                            DateofBirth = Convert.ToDateTime(sqlDataReader["DateofBirth"].ToString()),
                            RoleID = sqlDataReader["RoleID"].ToString(),
                            GenderID = Convert.ToInt32(sqlDataReader["GenderID"].ToString())
                        };
                    }
                    if (user != null)
                    {
                        SecretKeyQuestionAnswers secretKeyQuestionAnswers = new SecretKeyQuestionAnswers();
                        var ds = secretKeyQuestionAnswers.GetSecretKeyQuestionForuser(user.Email);
                        user.SecretKeyQuestion = ds.Tables[0].Rows[0][0].ToString();
                        user.SecretKeyAnswer = ds.Tables[0].Rows[0][1].ToString();
                    }
                }
            }
            return user;
        }
        public User AuthenticateUser(string email, string password)
        {
            User user = null;
            using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SPAuthenticate", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Email", email);
                    sqlCommand.Parameters.AddWithValue("@password", Convert.ToBase64String(Encoding.UTF8.GetBytes(password)));
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        user = new User()
                        {
                            UserID = Guid.Parse(sqlDataReader["UserID"].ToString()),
                            FirstName = sqlDataReader["FirstName"].ToString(),
                            LastName = sqlDataReader["LastName"].ToString(),
                            PhoneNumber = sqlDataReader["Phonenumber"].ToString(),
                            Email = sqlDataReader["Email"].ToString(),
                            DateofBirth = Convert.ToDateTime(sqlDataReader["DateofBirth"].ToString()),
                            RoleID = sqlDataReader["RoleID"].ToString(),
                            GenderID = Convert.ToInt32(sqlDataReader["GenderID"].ToString())
                        };
                    }
                    if (user != null)
                    {
                        SecretKeyQuestionAnswers secretKeyQuestionAnswers = new SecretKeyQuestionAnswers();
                        var ds = secretKeyQuestionAnswers.GetSecretKeyQuestionForuser(string.IsNullOrEmpty(email) ? user.Email : email);
                        user.SecretKeyQuestion = ds.Tables[0].Rows[0][0].ToString();
                        user.SecretKeyAnswer = ds.Tables[0].Rows[0][1].ToString();
                    }
                }
            }
            return user;
        }
        public bool AddUser(SecretKeyQuestionAnswers secretKeyQuestionAnswers)
        {
            bool isUserAdded = false;
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spAddUser", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                        sqlCommand.Parameters.AddWithValue("@Firstname", FirstName);
                        sqlCommand.Parameters.AddWithValue("@Lastname", LastName);
                        sqlCommand.Parameters.AddWithValue("@password", Convert.ToBase64String(Encoding.UTF8.GetBytes(Password)));
                        sqlCommand.Parameters.AddWithValue("@dateofbirth", DateofBirth);
                        sqlCommand.Parameters.AddWithValue("@phonenumber", PhoneNumber);
                        sqlCommand.Parameters.AddWithValue("@RoleID", RoleID);
                        sqlCommand.Parameters.AddWithValue("@genderID", GenderID);
                        sqlCommand.Parameters.AddWithValue("@Email", Email);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        secretKeyQuestionAnswers.AddSecretKeyQuestion(UserID);
                        isUserAdded = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isUserAdded;
        }
        public bool UpdateUser()
        {
            bool isUserUpdated = false;
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spUpdateUserProfile", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                        sqlCommand.Parameters.AddWithValue("@Firstname", FirstName);
                        sqlCommand.Parameters.AddWithValue("@Lastname", LastName);
                        sqlCommand.Parameters.AddWithValue("@dateofbirth", DateofBirth);
                        sqlCommand.Parameters.AddWithValue("@phonenumber", PhoneNumber);
                        sqlCommand.Parameters.AddWithValue("@GenderID", GenderID);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        isUserUpdated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isUserUpdated;
        }
        public bool UpdatePassword()
        {
            bool isPasswordUpdated = false;
            try
            {
                using (var sqlConnection = new SqlConnection(ExpensePlus.BusinessLogic.Common.SQLConnection.DatabaseConnection))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("spUpdatePasswordForuser", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                        sqlCommand.Parameters.AddWithValue("@password", Convert.ToBase64String(Encoding.UTF8.GetBytes(Password)));
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        isPasswordUpdated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isPasswordUpdated;
        }
        #endregion
    }
}
