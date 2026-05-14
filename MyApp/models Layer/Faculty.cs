public class Faculty
{
    private string facultyName;
    private string facultyCode;

    private List<Department> departments;

    private static List <Faculty> faculties = new List<Faculty>();
    private static List<string> IDList = new List<string>();

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

    public static List<Faculty> Faculties { get => faculties; set => faculties = value; }
    public static List<string> IDList1 { get => IDList; set => IDList = value; }


    
}