using System.Runtime.CompilerServices;

public class Admin: User
{
    private static  List <Admin> admins = new List<Admin>();
    //constructor
    public Admin(string id, string name, string email, string password, string phoneNumber, Address address)
        : base(id, name, email, password, phoneNumber, address)
    {
        admins.Add(this);
    }
    
    public static List<Admin> Admins { get => admins; set => admins = value; }
    //setters and getters
    public string ID1 { get => ID; set => ID = value; }
    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => password; set => password = value; }
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    public Address Address { get => address; set => address = value; }
    

}