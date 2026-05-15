public class Department
{
    private string name;
    private string ID;

    private List<Course> courses;
    private List<Teacher> teachers;

    private static List <Department> departments = new List<Department>();


    //constructor
    public Department(string name, string ID)
    {
        this.name = name;
        this.ID = ID;
        this.courses = new List<Course>();
        this.teachers = new List<Teacher>();
        departments.Add(this);
    }
    //setters and getters
    public string name1 { get => name; set => name = value; }
    public string ID1 { get => ID; set => ID = value; }
    public List<Course> Courses { get => courses; set => courses = value; }
    public List<Teacher> Teachers { get => teachers; set => teachers = value; }
    public static List<Department> Departments { get => departments; set => departments = value; }
    
}