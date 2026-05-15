public class TeacherService : ITeacherService
{
    public void gradeStudent(Student std, string courseCode, string grade)
    {
        try
        {
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == courseCode);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            if (!std.Courses.Contains(course))
            {
                throw new Exception("Student is not enrolled in this course");
            }
            for (int i = 0; i < std.Courses.Count; i++)
            {
                if (std.Courses[i].ID1 == courseCode)
                {
                    std.Grades[i] = grade;
                    Console.WriteLine("Grade assigned successfully");
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void showAllCourses(Teacher teacher)
    {
        foreach (Course course in teacher.Courses)
        {
            Console.WriteLine($"Course Code: {course.ID1}, Course Name: {course.Name}");
        }
    }
}