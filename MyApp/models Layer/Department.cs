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
    //setters and getters
    public string DepartmentName { get => departmentName; set => departmentName = value; }
    public string DepartmentCode { get => departmentCode; set => departmentCode = value; }
    public List<Course> Courses { get => courses; set => courses = value; }
    public List<Teacher> Teachers { get => teachers; set => teachers = value; }
    public static List<Department> Departments { get => departments; set => departments = value; }
    
}