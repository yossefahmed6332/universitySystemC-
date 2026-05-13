public class Admin: User
{
    //constructor
    public Admin(string id, string name, string email, string password, string phoneNumber, Adress address)
        : base(id, name, email, password, phoneNumber, address)
    {
    }


}