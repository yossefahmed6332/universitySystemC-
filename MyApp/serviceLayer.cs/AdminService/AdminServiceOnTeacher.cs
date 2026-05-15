public class AdminServiceOnTeacher : IAdminServiceOnTeacher
{
    
  


    //methods related to teacher 
    public void addTeacher (string id, string name, string email, string password, string phoneNumber, string addressID, double salaryPerHour, string hoursOfWork, string officeNumber, string role)
    {
        try
        {
            Address? address= Address.Addresses.FirstOrDefault(s=>s.ID==addressID);
            if (address == null)
            {
                throw new Exception ("Address not found");
            }
             Teacher teacher = new Teacher(id,name,email,password,phoneNumber,address,salaryPerHour,hoursOfWork,officeNumber,role);
            Teacher.Teachers.Add(teacher);
            Console.WriteLine("Teacher added successfully");
            
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);   
        }
    }

    public void removeTeacher (string teacherID)
    {
    try
        {
            Teacher? teacher= Teacher.Teachers.FirstOrDefault(t=>t.ID1==teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            Teacher.Teachers.Remove(teacher);
            teacher = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Teacher removed successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void changeTeacherPhoneNumber(string studentID, string phoneNumber)
    {
        try
        {
            Student? student=Student.Students.FirstOrDefault(s=>s.ID==studentID);
            if (student == null)
            {
                throw new Exception("Student not found");

            }
            student.PhoneNumber= phoneNumber;
            Console.WriteLine("Student phone number changed successfully");
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void changeTeacherEmail(string teacherID, string email)
    {
        try
        {
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            teacher.Email = email;
            Console.WriteLine("Teacher email changed successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public void changeTeacherPassword(string teacherID, string password)
    {
        try
        {
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            teacher.Password = password;
            Console.WriteLine("Teacher password changed successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }}

        public void changeTeacherAddress(string tacherId,string addressID)
    {
        try
        {
            Student? student = Student.Students.FirstOrDefault(s => s.ID == tacherId);
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
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
     public void changeTeacherSalary(string teacherID, double salary)
    {
        try
        {
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            teacher.SalaryPerHour = salary;
            Console.WriteLine("Teacher salary changed successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public void changeTeacherHoursOfWork(string teacherID, string hoursOfWork)
    {
        try
        {
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            teacher.HoursOfWork = hoursOfWork;
            Console.WriteLine("Teacher hours of work changed successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void changeTeacherCourses(string teacherID, List<Course> courses)
    {
        try
        {
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            teacher.Courses = courses;
            Console.WriteLine("Teacher courses changed successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public void changeTeacherOfficeNumber(string teacherID, string officeNumber)
    {
        try
        {
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            teacher.OfficeNumber = officeNumber;
            Console.WriteLine("Teacher office number changed successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public void changeTeacherRole(string teacherID, string role)
    {
        try
        {
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            teacher.Role = role;
            Console.WriteLine("Teacher role changed successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }}
    public void ShowAllTeachers()
    {
        if (Teacher.Teachers.Count == 0)
        {
            Console.WriteLine("No teachers found");
            return;
        }
        foreach (Teacher teacher in Teacher.Teachers)
        {
            Console.WriteLine($"ID: {teacher.ID1}, Name: {teacher.Name}, Email: {teacher.Email}, Phone Number: {teacher.PhoneNumber}, Address: {teacher.Address.Street}, {teacher.Address.City}, {teacher.Address.Country}, {teacher.Address.PostalCode}, Salary Per Hour: {teacher.SalaryPerHour}, Hours Of Work: {teacher.HoursOfWork}, Office Number: {teacher.OfficeNumber}, Role: {teacher.Role}");
        }
    }

    public void showSelfData(Admin admin)//parameter is the admin that is logged in and want to see his data
    {
        Console.WriteLine($"ID: {admin.ID1}, Name: {admin.Name}, Email: {admin.Email}, Phone Number: {admin.PhoneNumber}, Address: {admin.Address.Street}, {admin.Address.City}, {admin.Address.Country}, {admin.Address.PostalCode}");
    }

public void showTeacherData(string teacherID)
    {
        try
        {
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID1 == teacherID);
            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            Console.WriteLine($"ID: {teacher.ID1}, Name: {teacher.Name}, Email: {teacher.Email}, Phone Number: {teacher.PhoneNumber}, Address: {teacher.Address.Street}, {teacher.Address.City}, {teacher.Address.Country}, {teacher.Address.PostalCode}, Salary Per Hour: {teacher.SalaryPerHour}, Hours Of Work: {teacher.HoursOfWork}, Office Number: {teacher.OfficeNumber}, Role: {teacher.Role}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}