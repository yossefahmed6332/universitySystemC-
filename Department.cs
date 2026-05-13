public class Department
{
    private string departmentName;
    private string departmentCode;

    private List<Course> courses;
    private List<Teacher> teachers;

    //constructor
    public Department(string departmentName, string departmentCode)
    {
        this.departmentName = departmentName;
        this.departmentCode = departmentCode;
    }
}