using System.Net.Sockets;

public abstract class User
{
    protected string ID; 
    protected string name ; 
    protected string email ; 
    protected string password ; 

    protected string phoneNumber ;
    protected Address address;

    // Constructor
    public User(string id, string name, string email, string password, string phoneNumber, Address address)
    {
        this.ID = id;
        this.name = name;
        this.email = email;
        this.password = password;
        this.phoneNumber = phoneNumber;
        this.address = address;
    }

}