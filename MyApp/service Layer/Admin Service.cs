using System.ComponentModel;
using System.Diagnostics.Contracts;

public class AdminService
{
    //create methods for creating university, faculty, department, course, teacher and student
    public University CreateUniversity(string name, string location)
    {
        University university = new University(name, location);
        return university;
    }
    public Faculty CreateFaculty(string name, University university)
    {
        Faculty faculty = new Faculty(name, university);
        return faculty;
    }
    public Department CreateDepartment(string name, Faculty faculty)
    {
        Department department = new Department(name, faculty);
        return department;
    }
    public Course CreateCourse(string name, string code, int creditHours, Department department)
    {
        Course course = new Course(name, code, creditHours, department);
        return course;
    }
    public Teacher CreateTeacher(string id, string name, string email, string password, string phoneNumber, Adress address, Department department)
    {
        Teacher teacher = new Teacher(id, name, email, password, phoneNumber, address, department);
        return teacher;
    }
    public Student CreateStudent(string id, string name, string email, string password, string phoneNumber, Adress address, Department department)
    {
        Student student = new Student(id, name, email, password, phoneNumber, address, department);
        return student;
    }
    public Cleaner CreateCleaner(string id, string name, string email, string password, string phoneNumber, Adress address)
    {
        Cleaner cleaner = new Cleaner(id, name, email, password, phoneNumber, address);
        return cleaner;
    }
    
    
    //delete methods for deleting university, faculty, department, course, teacher and student
    public void DeleteUniversity(University university)
    {
        University.universities.Remove(university);
    }
    public void DeleteFaculty(Faculty faculty)
    {
        Faculty.faculties.Remove(faculty);
    }
    public void DeleteDepartment(Department department)
    {
        Department.departments.Remove(department);
    }
    public void DeleteCourse(Course course)
    {
        Course.courses.Remove(course);
    }
    public void DeleteTeacher(Teacher teacher)
    {
        Teacher.teachers.Remove(teacher);
    }
    public void DeleteStudent(Student student)
    {
        Student.students.Remove(student);
    }
    public void DeleteCleaner(Cleaner cleaner)
    {
        Cleaner.cleaners.Remove(cleaner);
    }

    //methods impact student 

    //add student to course
    public void EnrollStudentInCourse(Student student, Course course)
    {
        student.courses.Add(course);
        course.students.Add(student);
    }

    //remove student from course
    public void UnenrollStudentFromCourse(Student student, Course course)
    {
        student.courses.Remove(course);
        course.students.Remove(student);
    }

    //assign grade to student
    public void AssignGrade(string studentID, string courseID, double grade)
    {
        int index = Course.courses.FindIndex(c => c.Id == courseID);
        Student student=student.students.Find(s => s.Id == studentID);
        student.
    }


}