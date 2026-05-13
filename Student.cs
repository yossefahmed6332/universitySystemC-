using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Student: User
{
    private double GPA;
    private List<Course> courses;
    private Department department;
    private List<Grade> grades;

    private static List <Student> students = new List<Student>();
    //constructor
    public Student(string id, string name, string email, string password, string phoneNumber, Adress address, double GPA, List<Course> courses, Department department, List<Grade> grades)
        : base(id, name, email, password, phoneNumber, address)
    {
        this.GPA = GPA;
        this.courses = courses;
        this.department = department;
        this.grades = grades;
        students.Add(this);
    }
}