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
    public Student(string id, string name, string email, string password, string phoneNumber, Address address, Department department)
        : base(id, name, email, password, phoneNumber, address)
    {
        this.GPA = 0.0;
        this.courses = new List<Course>();
        this.department = department;
        this.grades = new List<string>();
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
    public string ID { get => ID; set => ID = value; }
    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => password; set => password = value; }
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

    public static List<Student> Students { get => students; set => students = value; }
    
}