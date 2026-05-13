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
        faculties.Add(this);
    }
}