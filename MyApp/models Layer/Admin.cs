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
    

}