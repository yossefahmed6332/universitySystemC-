public class User : IUserOperations 
{
    protected string name;
    protected string email;
    protected string password;
    protected string ID;
    protected string phoneNumber;

    public User(string name, string email, string password, string ID, string phoneNumber)
    {
        this.name = name;
        this.email = email;
        this.password = password;
        this.ID = ID;
        this.phoneNumber = phoneNumber;
    }

    public Boolean login(String username, String password,List<User> users)
    {
        if (users.Any(u => u.email == username && u.password == password))//check if the email and password match any user in the list
        {            return true; // Login successful
        }
        return false ; // Login failed
    }

    public Boolean register(String name, String email, String password, String ID, String phoneNumber,List<User> users)
    {
        if (users.Any(u => u.email == email))
        {
            return false; // Email already exists
        }
        users.Add(this);
        return true;
    }
}