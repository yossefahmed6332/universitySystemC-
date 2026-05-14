public class Employee: User
{
    protected double salaryPerHour;
    protected string hoursOfWork;

    

    //constructor
    public Employee(string id, string name, string email, string password, string phoneNumber, Address address, double salaryPerHour, string hoursOfWork)
        : base(id, name, email, password, phoneNumber, address)
    {
        this.salaryPerHour = salaryPerHour;
        this.hoursOfWork = hoursOfWork;
    }

    
}