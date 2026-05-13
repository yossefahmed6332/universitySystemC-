public class Department
{
    private string departmentName;
    private string departmentCode;

    private List<Course> courses;
    private List<Teacher> teachers;

    private static List <Department> departments = new List<Department>();


    //constructor
    public Department(string departmentName, string departmentCode)
    {
        this.departmentName = departmentName;
        this.departmentCode = departmentCode;
        this.courses = new List<Course>();
        this.teachers = new List<Teacher>();
        departments.Add(this);
    }
}