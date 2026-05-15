public class Teacher: Employee
{
    private List <Course> courses;
    private string officeNumber;
    private string role;
    

    private static List <Teacher> teachers = new List<Teacher>();

    //constructor
    public Teacher(string id, string name, string email, string password, string phoneNumber, Address address, double salaryPerHour, string hoursOfWork,  string officeNumber, string role)
        : base(id, name, email, password, phoneNumber, address, salaryPerHour, hoursOfWork)
    {
        courses = new List<Course>();
        this.officeNumber = officeNumber;
        this.role = role;
        teachers.Add(this);
    }

    //setters and getters
    public List<Course> Courses 
    {
         get => courses; set => courses = value; 
         }
    public string OfficeNumber { 
        get => officeNumber; set => officeNumber = value; 
        }
    public string Role {
         get => role; set => role = value;
          }

    public string ID1 { get => ID; set => ID = value; }
    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => password; set => password = value; }
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    public Address Address { get => address; set => address = value; }
    public double SalaryPerHour { get => salaryPerHour; set => salaryPerHour = value; }
    public string HoursOfWork { get => hoursOfWork; set => hoursOfWork = value; }
    
    public static List<Teacher> Teachers { get => teachers; set => teachers = value; }


}