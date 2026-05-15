public class Cleaner: Employee
{
    private Location Location;
    private static List <Cleaner> cleaners = new List<Cleaner>();


    //constructor
    public Cleaner(string id, string name, string email, string password, string phoneNumber, Address address, double salaryPerHour, string hoursOfWork, Location location)
        : base(id, name, email, password, phoneNumber, address, salaryPerHour, hoursOfWork)
    {
        this.Location = location;
        cleaners.Add(this);
    }
    //setters and getters
    public Location Location1 { get => Location; set =>
        Location = value; }
    
    public static List<Cleaner> Cleaners { get => cleaners; set => cleaners = value; }
    public string ID { get => ID; set => ID = value; }
    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => password; set => password = value; }
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    public Address Address { get => address; set => address = value; }
    public double SalaryPerHour { get => salaryPerHour; set => salaryPerHour = value; }
    public string HoursOfWork { get => hoursOfWork; set => hoursOfWork = value; }
    
}