public class Course
{
    private string courseName;
    private string courseCode;
    private int creditHours;
    private Department department;

    //constructor
    public Course(string courseName, string courseCode, int creditHours, Department department)
    {
        this.courseName = courseName;
        this.courseCode = courseCode;
        this.creditHours = creditHours;
        this.department = department;
    }
}