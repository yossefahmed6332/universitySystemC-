public class Teacher: Employee
{
    private List <Course> courses;
    private string officeNumber;
    private string role;

    private static List <Teacher> teachers = new List<Teacher>();

    //constructor
    public Teacher(string id, string name, string email, string password, string phoneNumber, Address address, double salaryPerHour, string hoursOfWork, List<Course> courses, string officeNumber, string role)
        : base(id, name, email, password, phoneNumber, address, salaryPerHour, hoursOfWork)
    {
        this.courses = courses;
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

    //add and remove courses
    public void addCourse(Course course)
    {
        courses.Add(course);
    }
    public void removeCourse (Course course)
    {
        courses.Remove(course);
    }
    public static List<Teacher> Teachers { get => teachers; set => teachers = value; }


}