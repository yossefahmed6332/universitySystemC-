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
}