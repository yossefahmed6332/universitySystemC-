public class AdminServicesOnDepartment: IAdminServiceOnDepartment
{
      //methods related to department
    public void addDepartment(string id, string name)
    {
        try
        {
            Department department = new Department(id, name);
            Department.Departments.Add(department);
            Console.WriteLine("Department added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void removeDepartment(string id)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            Department.Departments.Remove(department);
            department = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Department removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeDepartmentName(string id, string newName)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            department.name1 = newName;
            Console.WriteLine("Department name changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeDepartmentCourses(string id, List<Course> newCourses)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            department.Courses = newCourses;
            Console.WriteLine("Department courses changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeDepartmentTeachers(string id, List<Teacher> newTeachers)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            department.Teachers = newTeachers;
            Console.WriteLine("Department teachers changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void addTeacherToDepartment(string id, string teacherID)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            department.Teachers.Add(teacher);
            Console.WriteLine("Teacher added to department successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
   
    public void removeTeacherFromDepartment(string id, string teacherID)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            department.Teachers.Remove(teacher);
            teacher = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Teacher removed from department successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void addCourseToDepartment(string id, string courseID)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == courseID);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            department.Courses.Add(course);
            Console.WriteLine("Course added to department successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void removeCourseFromDepartment(string id, string courseID)
    {
       try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            Course? course = Course.Courses.FirstOrDefault(c => c.ID1 == courseID);
            if (course == null)
            {
                throw new Exception("Course not found");
            }
            department.Courses.Remove(course);
            course = null ; 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Course removed from department successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public void showAllDepartments()
    {
        if (Department.Departments.Count == 0)
        {
            Console.WriteLine("No departments found");
            return;
        }
        foreach (Department department in Department.Departments)
        {
            Console.WriteLine($"ID: {department.ID1}, Name: {department.name1}, Courses: {string.Join(", ", department.Courses.Select(c => c.Name))}, Teachers: {string.Join(", ", department.Teachers.Select(t => t.Name))}");
        }
    }
    public void showAllCoursesInDepartment(string departmentCode)
    {
        Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == departmentCode);
        if (department == null)
        {
            Console.WriteLine("Department not found");
            return;
        }
        if (department.Courses.Count == 0)
        {
            Console.WriteLine("No courses found in this department");
            return;
        }
        foreach (Course course in department.Courses)
        {
            Console.WriteLine($"ID: {course.ID1}, Name: {course.Name}, Credit Hours: {course.CreditHours}");
        }
    }
    public void showDepartmentData(string id)
    {
        try
        {
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            Console.WriteLine($"ID: {department.ID1}, Name: {department.name1}, Courses: {string.Join(", ", department.Courses.Select(c => c.Name))}, Teachers: {string.Join(", ", department.Teachers.Select(t => t.Name))}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}