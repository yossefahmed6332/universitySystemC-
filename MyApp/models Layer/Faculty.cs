public class Faculty
{
    private string name;
    private string ID;

    private List<Department> departments;

    private static List <Faculty> faculties = new List<Faculty>();
    private static List<string> IDList = new List<string>();

    //constructor
    public Faculty(string facultyName, string facultyCode)
    {
        this.name = facultyName;
        this.ID = facultyCode;
        this.departments = new List<Department>();
        faculties.Add(this);
    }

    //setters and getters
    public string Name { get => name; set => name = value; }
    public string ID1 { get => ID; set => ID = value; }
    public List<Department> Departments { get => departments; set => departments = value; }

    public static List<Faculty> Faculties { get => faculties; set => faculties = value; }
    public static List<string> IDList1 { get => IDList; set => IDList = value; }


    
}