namespace ExpensePlus.BusinessLogic.Login
{
    public interface IUser
    {
        DateTime DateofBirth { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        int GenderID { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string PhoneNumber { get; set; }
        string RoleID { get; set; }
        Guid UserID { get; set; }

        User AuthenticateUser(string username, string password);
    }
}