using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensePlus.BusinessLogic.Login
{
    public class User : IUser
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

                }
            }
            return user;
        }
        public bool AddUser()
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
        #endregion
    }
}
