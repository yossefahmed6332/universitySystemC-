class User
{
    protected string name;
    protected string email;
    protected string password;
    protected string ID;  
    protected string phoneNumber;


    User(string name, string email, string password, string ID, string phoneNumber)
    {
        this.name = name;
        this.email = email;
        this.password = password;
        this.ID = ID;
        this.phoneNumber = phoneNumber;
    }
}