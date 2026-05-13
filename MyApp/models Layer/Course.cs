public class Course
{
    private string courseName;
    private string courseCode;
    private int creditHours;
    private Department department;
    private static List <Course> courses = new List<Course>();

    //constructor
    public Course(string courseName, string courseCode, int creditHours, Department department)
    {
        this.courseName = courseName;
        this.courseCode = courseCode;
        this.creditHours = creditHours;
        this.department = department;
        courses.Add(this);
    }
    //setters and getters
    public string CourseName { get => courseName; set => courseName = value; }
    public string CourseCode { get => courseCode; set => courseCode = value; }
    public int CreditHours { get => creditHours; set => creditHours = value; }
    public Department Department { get => department; set => department = value; }
    
}