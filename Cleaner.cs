public class Cleaner: Employee
{
    private Location Location;
    private static List <Cleaner> cleaners = new List<Cleaner>();

    //constructor
    public Cleaner(string id, string name, string email, string password, string phoneNumber, Adress address, double salaryPerHour, string hoursOfWork, Location location)
        : base(id, name, email, password, phoneNumber, address, salaryPerHour, hoursOfWork)
    {
        this.Location = location;
        cleaners.Add(this);
    }
}