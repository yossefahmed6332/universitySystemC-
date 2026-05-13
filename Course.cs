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
}