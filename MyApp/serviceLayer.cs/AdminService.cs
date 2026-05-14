public class AdminService
{
    //methods impact student 

    //add student
    public void addStudent(string id, string name, string email, string password, string phoneNumber, Address address, double GPA, List<Course> courses, Department department, List<string> grades)
    {
        Student student = new Student(id, name, email, password, phoneNumber, address, GPA, courses, department, grades);
    }

    //remove student
    public void removeStudent(Student student)
    {
        Student.students.Remove(student);
    }
}