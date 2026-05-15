public class AdminServiceOnCourse : IAdminServiceOnCourse
{
  
    //methods related to course 
    public void addCourse(string id, string name, int credits, string departmentID)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == departmentID);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            Course course = new Course(id, name, credits, department);
            Course.Courses.Add(course);
            Console.WriteLine("Course added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void removeCourse(string id)
    {
        try
        {
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == id);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            Course.Courses.Remove(course);
            course=null ; 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Course removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void showAllCourses()
    {
        if (Course.Courses.Count == 0)
        {
            Console.WriteLine("No courses found");
            return;
        }
        foreach (Course course in Course.Courses)
        {
            Console.WriteLine($"ID: {course.ID1}, Name: {course.Name}, Credits: {course.CreditHours}, Department: {course.Department.name1}");
        }
    
    }
    
    public void changeCourseName(string id, string newName)
    {
        try
        {
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == id);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            course.Name = newName;
            Console.WriteLine("Course name changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }}
    public void changeCourseCreditHours(string id, int newCredits)
    {
        try
        {
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == id);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            course.CreditHours = newCredits;
            Console.WriteLine("Course credits changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }}

    public void changeCourseDepartment(string id, string newDepartmentID){
        try
        {
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == id);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == newDepartmentID);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            course.Department = department;
            Console.WriteLine("Course department changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }}
        public void showCourseData(string id)
    {
        try
        {
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == id);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            Console.WriteLine($"ID: {course.ID1}, Name: {course.Name}, Credits: {course.CreditHours}, Department: {course.Department.name1}");      
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }



}