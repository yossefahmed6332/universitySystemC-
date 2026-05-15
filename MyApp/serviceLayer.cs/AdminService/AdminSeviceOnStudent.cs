public class AdminServiceOnStudent : IAdminServiceOnStudent
{
    
    
    //methods related to student
    public void addStudent(string id, string name, string email, string password, string phoneNumber, string addressID, string departmentID)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == addressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            Department? department=Department.Departments.FirstOrDefault(a=>a.ID1==departmentID);
            if(department==null)
            {
                throw new Exception("Department not found");
            }
            Student student = new Student(id, name, email, password, phoneNumber, address, department);
            Student.Students.Add(student);
            Console.WriteLine("Student added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



    }
    public void removeStudent(string id)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s => s.ID == id);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            Student.Students.Remove(student);
            student = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Student removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeStudentPhoneNumber(string id, string newPhoneNumber)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s => s.ID == id);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            student.PhoneNumber = newPhoneNumber;
            Console.WriteLine("Student phone number changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeStudentEmail (string ID , string newEmail)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s => s.ID == ID);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            student.Email = newEmail;
            Console.WriteLine("Student email changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void changeStudentPassword(string ID , string password)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s=> s.ID==ID); 
            if (student == null)
            {
                throw new Exception ("student not found");
            }
            student.Password= password; 
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void changeStudentAddress(string addressID,string studentID)
    {
        try {
            Student? student = Student.Students.FirstOrDefault(s => s.ID == studentID);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == addressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            student.Address = address;
            Console.WriteLine("Student address changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
      
    }

    public void changeStudentGPA(string studentID,double newGPA)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s=>s.ID==studentID);
            if (student == null)
            {
                throw new Exception("student not found ");
            }
            student.GPA1=newGPA;
            Console.WriteLine("Student GPA changed successfully");
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }

    }

    public void changeStudentCourses(string studentID , List<Course> courses)
    {
        try { 
        Student? student = Student.Students.FirstOrDefault(s => s.ID == studentID);
        if (student == null)
            {
                throw new Exception("Student not found");
            }
            student.Courses = courses;
            Console.WriteLine("Student courses changed successfully");
    }
    catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void changeStudentDepartment(string studentID, string departmentID)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s => s.ID == studentID);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            Department? department = Department.Departments.FirstOrDefault(d => d.ID1 == departmentID);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            student.Department = department;
            Console.WriteLine("Student department changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void changeStudentGrades(string studentID, List<string> newGrades)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s => s.ID == studentID);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            student.Grades = newGrades;
            Console.WriteLine("Student grades changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }}

    public void showAllStudents()
    {
        if (Student.Students.Count == 0)
        {
            Console.WriteLine("No students found");
            return;
        }
        foreach (Student student in Student.Students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Email: {student.Email}, Phone Number: {student.PhoneNumber}, Address: {student.Address.Street}, {student.Address.City}, {student.Address.Country}, {student.Address.PostalCode}, GPA: {student.GPA1}, Department: {student.Department.name1}, Courses: {string.Join(", ", student.Courses.Select(c => c.Name))}, Grades: {string.Join(", ", student.Grades)}");
        }
    }   
    public void showStudentData(string studentID)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s => s.ID == studentID);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Email: {student.Email}, Phone Number: {student.PhoneNumber}, Address: {student.Address.Street}, {student.Address.City}, {student.Address.Country}, {student.Address.PostalCode}, GPA: {student.GPA1}, Department: {student.Department.name1}, Courses: {string.Join(", ", student.Courses.Select(c => c.Name))}, Grades: {string.Join(", ", student.Grades)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}