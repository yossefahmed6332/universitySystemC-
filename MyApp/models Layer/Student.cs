using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Student: User
{
    private double GPA;
    private List<Course> courses;
    private Department department;
    private List<string> grades;

    private static List <Student> students = new List<Student>();
    //constructor
    public Student(string id, string name, string email, string password, string phoneNumber, Address address, double GPA, List<Course> courses, Department department, List<string> grades)
        : base(id, name, email, password, phoneNumber, address)
    {
        this.GPA = GPA;
        this.courses = courses;
        this.department = department;
        this.grades = grades;
        students.Add(this);
    }
    //setters and getters
    public double GPA1 { 
        get => GPA; set => GPA = value; 
        }
    public List<Course> Courses {
         get => courses; set => courses = value;
          }
    public Department Department { 
        get => department; set => department = value;
         }
    public List<string> Grades { 
        get => grades; set => grades = value;
         }
    
}