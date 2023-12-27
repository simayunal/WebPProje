using WebProje1.Models;

public class UserService
{
    private List<UserAccount> _users;

    public UserService()
    {
        _users = new List<UserAccount>
        {
            new UserAccount { UserName = "admin", Password = "admin123" },
            new UserAccount { UserName = "user", Password = "user123" }
        };
    }

    public UserAccount GetUser(string userName)
    {
        return _users.FirstOrDefault(u => u.UserName == userName);
    }
}
