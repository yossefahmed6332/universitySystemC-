public class University
{
    private string universityName;
    private string universityCode;

    private List<Faculty> faculties;

     private static List <University> universities = new List<University>();

    //constructor
    public University(string universityName, string universityCode)
    {
        this.universityName = universityName;
        this.universityCode = universityCode;
        this.faculties = new List<Faculty>();
        universities.Add(this);

    }

    //setters and getters
    public string UniversityName { get => universityName; set => universityName = value; }
    public string UniversityCode { get => universityCode; set => universityCode = value; }
    public List<Faculty> Faculties { get => faculties; set => faculties = value; }
    public static List<University> Universities { get => universities; set => universities = value; }
}