public class StudentService : IStudentService
{
    public void addCourse(Student std, string courseCode)
    {
        try
        {
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == courseCode);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            std.Courses.Add(course);
            Console.WriteLine("Course added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void dropCourse(Student std, string courseCode)
    {
        try
        {
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == courseCode);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            std.Courses.Remove(course);
            Console.WriteLine("Course dropped successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void showAllCourses(Student std)
    {
        if (std.Courses.Count == 0)
        {
            Console.WriteLine("No courses found");
            return;
        }
        foreach (Course course in std.Courses)
        {
            Console.WriteLine($"ID: {course.ID1}, Name: {course.Name}, Credit Hours: {course.CreditHours}, Department: {course.Department}");
        }
    }
    public void showAllGrades(Student std)
    {
        if (std.Grades.Count == 0)
        {
            Console.WriteLine("No grades found");
            return;
        }
        foreach (string grade in std.Grades)
        {
            Console.WriteLine($"Grade: {grade}"); 
        }
    }
    public void showGPA(Student std)
    {
        Console.WriteLine($"GPA: {std.GPA1}");
    }
    public void calculateGPA(Student std)
    {
        if (std.Grades.Count == 0)
        {
            Console.WriteLine("No grades found");
            return;
        }
        double totalPoints = 0;
        int totalCreditHours = 0;
        for (int i = 0; i < std.Grades.Count; i++)
        {
            string grade = std.Grades[i];
            Course course = std.Courses[i];
            double points = 0;
            switch (grade)
            {
                case "A":
                    points = 4;
                    break;
                case "B":
                    points = 3;
                    break;
                case "C":
                    points = 2;
                    break;
                case "D":
                    points = 1;
                    break;
                case "F":
                    points = 0;
                    break;
                default:
                    Console.WriteLine($"Invalid grade: {grade}");
                    return;
            }
            totalPoints += points * course.CreditHours;
            totalCreditHours += course.CreditHours;
        }
        std.GPA1 = totalPoints / totalCreditHours;
        Console.WriteLine("GPA calculated successfully");
    }

}