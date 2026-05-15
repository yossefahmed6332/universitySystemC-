public class Course
{
    private string name;
    private string ID;
    private int creditHours;
    private Department department;
    private static List <Course> courses = new List<Course>();

    //constructor
    public Course(string name, string ID, int creditHours, Department department)
    {
        this.name = name;
        this.ID = ID;
        this.creditHours = creditHours;
        this.department = department;
        courses.Add(this);
    }
    //setters and getters
    public string Name { get => name; set => name = value; }
    public string ID1 { get => ID; set => ID = value; }
    public int CreditHours { get => creditHours; set => creditHours = value; }
    public Department Department { get => department; set => department = value; }

    public static List<Course> Courses { get => courses; set => courses = value; }
    
}