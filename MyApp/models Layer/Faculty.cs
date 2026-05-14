public class Faculty
{
    private string facultyName;
    private string facultyCode;

    private List<Department> departments;

    private static List <Faculty> faculties = new List<Faculty>();

    //constructor
    public Faculty(string facultyName, string facultyCode)
    {
        this.facultyName = facultyName;
        this.facultyCode = facultyCode;
        this.departments = new List<Department>();
        faculties.Add(this);
    }

    //setters and getters
    public string FacultyName { get => facultyName; set => facultyName = value; }
    public string FacultyCode { get => facultyCode; set => facultyCode = value; }
    public List<Department> Departments { get => departments; set => departments = value; }
    
}