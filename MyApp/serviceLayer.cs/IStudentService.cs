using System.Reflection.PortableExecutable;

public interface IStudentService
{
    //functions related to student
    public void addCourse(Student std , string courseCode);
    public void dropCourse(Student std , string courseCode);
    public void showAllCourses(Student std);
    public void showAllGrades(Student std);
    public void showGPA(Student std);
    public void calculateGPA(Student std);
    
    


}