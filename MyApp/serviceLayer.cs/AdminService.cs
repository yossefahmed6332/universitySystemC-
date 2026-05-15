using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Security.Authentication.ExtendedProtection;

public class AdminService : IAdminService
{

    //methods related to admin
    public void AddAdmin(string id, string name, string email, string password, string phoneNumber, string addressID)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == addressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            Admin admin = new Admin(id, name, email, password, phoneNumber, address);
            Console.WriteLine("Admin added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changePhoneNumber(string id, string newPhoneNumber)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            admin.PhoneNumber = newPhoneNumber;
            Console.WriteLine("Phone number changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeEmail(string id, string newEmail)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            admin.Email = newEmail;
            Console.WriteLine("Email changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void changePassword(string id, string newPassword)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            admin.Password = newPassword;
            Console.WriteLine("Password changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public void changeAddress(string id, string newAddressID)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == newAddressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            admin.Address = address;
            Console.WriteLine("Address changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void RemoveAdmin(string id)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            Admin.Admins.Remove(admin);
            admin = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Admin removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void showAllAdmins()
    {
        if (Admin.Admins.Count == 0)
        {
            Console.WriteLine("No admins found");
            return;
        }
        foreach (Admin admin in Admin.Admins)
        {
            Console.WriteLine($"ID: {admin.ID}, Name: {admin.Name}, Email: {admin.Email}, Phone Number: {admin.PhoneNumber}, Address: {admin.Address.Street}, {admin.Address.City}, {admin.Address.Country}, {admin.Address.PostalCode}, Country: {admin.Address.Country}");
        }
    }

    //methods related to address
    public void AddAddress(string id, string street, string city, string state, string postalCode,string country)
    {
        try
        {
            Address address = new Address(id, street, city, state, country, postalCode);
            Address.Addresses.Add(address);
            Console.WriteLine("Address added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void RemoveAddress(string id)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            Address.Addresses.Remove(address);
            address = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Address removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeStreet(string id, string newStreet)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            address.Street = newStreet;
            Console.WriteLine("Street changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCity(string id, string newCity)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            address.City = newCity;
            Console.WriteLine("City changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changePostalCode(string id, string postalCode)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            address.PostalCode = postalCode;
            Console.WriteLine("Postal code changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changecountry(string id, string newCountry)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            address.Country = newCountry;
            Console.WriteLine("Country changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void showAllAddresses()
    {
        if (Address.Addresses.Count == 0)
        {
            Console.WriteLine("No addresses found");
            return;
        }
        foreach (Address address in Address.Addresses)
        {
            Console.WriteLine($"ID: {address.ID}, Street: {address.Street}, City: {address.City}, State: {address.Country}, Postal Code: {address.PostalCode}, Country: {address.Country}");
        }
    }
    //methods related to cleaner
    public void AddCleaner(string id, string name, string email, string password, string phoneNumber, string addressID, double salaryPerHour, string hoursOfWork, string locationID)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == addressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationID);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            Cleaner cleaner = new Cleaner(id, name, email, password, phoneNumber, address, salaryPerHour, hoursOfWork, location);
            Cleaner.Cleaners.Add(cleaner);
            Console.WriteLine("Cleaner added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void RemoveCleaner(string id)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            Cleaner.Cleaners.Remove(cleaner);
            cleaner = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Cleaner removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerPhoneNumber(string id, string newPhoneNumber)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.PhoneNumber = newPhoneNumber;
            Console.WriteLine("Cleaner phone number changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerEmail(string id, string newEmail)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.Email = newEmail;
            Console.WriteLine("Cleaner email changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerPassword(string id , string newPassword)

    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.Password = newPassword;
            Console.WriteLine("Cleaner password changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerAddress(string id, string newAddressID)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == newAddressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            cleaner.Address = address;
            Console.WriteLine("Cleaner address changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerSalary(string id, double newSalary)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.SalaryPerHour = newSalary;
            Console.WriteLine("Cleaner salary changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void changeCleanerHoursOfWork(string id, string newHoursOfWork)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.HoursOfWork = newHoursOfWork;
            Console.WriteLine("Cleaner hours of work changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public void changeCleanerLocation(string id, string newLocationID)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == newLocationID);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            cleaner.Location1 = location;
            Console.WriteLine("Cleaner location changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    
    }
    public void showAllCleaners()
    {
        if (Cleaner.Cleaners.Count == 0)
        {
            Console.WriteLine("No cleaners found");
            return;
        }
        foreach (Cleaner cleaner in Cleaner.Cleaners)
        {
            Console.WriteLine($"ID: {cleaner.ID}, Name: {cleaner.Name}, Email: {cleaner.Email}, Phone Number: {cleaner.PhoneNumber}, Address: {cleaner.Address.Street}, {cleaner.Address.City}, {cleaner.Address.PostalCode}, Salary Per Hour: {cleaner.SalaryPerHour}, Hours Of Work: {cleaner.HoursOfWork}, Location: {cleaner.Location1.Building}, {cleaner.Location1.Floor}");
        }
    }

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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
    public void showAllTeachers()
    {
        if (Teacher.Teachers.Count == 0)
        {
            Console.WriteLine("No teachers found");
            return;
        }
        foreach (Teacher teacher in Teacher.Teachers)
        {
            Console.WriteLine($"ID: {teacher.ID}, Name: {teacher.Name}, Email: {teacher.Email}, Phone Number: {teacher.PhoneNumber}, Address: {teacher.Address.Street}, {teacher.Address.City}, {teacher.Address.Country}, {teacher.Address.PostalCode}, Salary Per Hour: {teacher.SalaryPerHour}, Hours Of Work: {teacher.HoursOfWork}, Office Number: {teacher.OfficeNumber}, Role: {teacher.Role}");
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

    //methods related to faculty 
    public void addFaculty(string facultyCode, string facultyName)
    {
        try
        {
            Faculty faculty=new Faculty(facultyCode,facultyName);
            Faculty.Faculties.Add(faculty);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void removeFaculty(string facultyCode)
    {
        try
        {
            Faculty? faculty = Faculty.Faculties.FirstOrDefault(f => f.ID1 == facultyCode);
            if (faculty == null)
            {
                throw new Exception("Faculty not found");
            }
            Faculty.Faculties.Remove(faculty);
            faculty = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Faculty removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeFacultyName(string facultyCode, string newFacultyName)
    {
        try
        {
            Faculty? faculty = Faculty.Faculties.FirstOrDefault(f => f.ID1 == facultyCode);
            if (faculty == null)
            {
                throw new Exception("Faculty not found");
            }
            faculty.Name = newFacultyName;
            Console.WriteLine("Faculty name changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeFacultyDepartments(string facultyCode, List<Department> newDepartments)
    {
        try
        {
            Faculty? faculty = Faculty.Faculties.FirstOrDefault(f => f.ID1 == facultyCode);
            if (faculty == null)
            {
                throw new Exception("Faculty not found");
            }
            faculty.Departments = newDepartments;
            Console.WriteLine("Faculty departments changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void addDepartmentToFaculty(string facultyCode, Department department)
    {
        try
        {
            Faculty? faculty = Faculty.Faculties.FirstOrDefault(f => f.ID1 == facultyCode);
            if (faculty == null)
            {
                throw new Exception("Faculty not found");
            }
            faculty.Departments.Add(department);
            Console.WriteLine("Department added to faculty successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void removeDepartmentFromFaculty(string facultyCode, Department department)  {
        try
        {
            Faculty? faculty = Faculty.Faculties.FirstOrDefault(f => f.ID1 == facultyCode);
            if (faculty == null)
            {
                throw new Exception("Faculty not found");
            }
            faculty.Departments.Remove(department);
            faculty =null; 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Department removed from faculty successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
}
    public void showAllFaculties (string ID)
    {

        try {
        Faculty? faculty= Faculty.Faculties.FirstOrDefault(u=>u.ID1==ID); 
        if (faculty == null)
            {
                throw new Exception("Faculty not found");

            }
            foreach (Faculty f in Faculty.Faculties)
            {
                Console.WriteLine($"ID: {f.ID1}, Name: {f.Name}, Departments: {string.Join(", ", f.Departments.Select(d => d.name1))}");
            }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);  
    
    }

}
    
    //methods related to location
    public void AddLocation(string locationCode, string locationName, string locationType)
    {
        try
        {
            Location location = new Location(locationCode, locationName, locationType);
            Location.Locations.Add(location);
            Console.WriteLine("Location added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void RemoveLocation(string locationCode)
    {
        try
        {
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationCode);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            Location.Locations.Remove(location);
            location = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Location removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeLocationName(string locationCode, string newLocationName)
    {
        try
        {
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationCode);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            location.Building = newLocationName;
            Console.WriteLine("Location name changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeLocationBuilding(string locationCode, string newLocationBuilding)
    {
        try
        {
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationCode);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            location.Building = newLocationBuilding;
            Console.WriteLine("Location building changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void showAllLocations()
    {
        if (Location.Locations.Count == 0)
        {
            Console.WriteLine("No locations found");
            return;
        }
        foreach (Location location in Location.Locations)
        {
            Console.WriteLine($"ID: {location.ID1}, Name: {location.Building}, Type: {location.Floor}");
        }
    }
    
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
            Teacher? teacher= Teacher.Teachers.FirstOrDefault(t=>t.ID==teacherID);
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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
            Teacher? teacher = Teacher.Teachers.FirstOrDefault(t => t.ID == teacherID);
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
            Console.WriteLine($"ID: {teacher.ID}, Name: {teacher.Name}, Email: {teacher.Email}, Phone Number: {teacher.PhoneNumber}, Address: {teacher.Address.Street}, {teacher.Address.City}, {teacher.Address.Country}, {teacher.Address.PostalCode}, Salary Per Hour: {teacher.SalaryPerHour}, Hours Of Work: {teacher.HoursOfWork}, Office Number: {teacher.OfficeNumber}, Role: {teacher.Role}");
        }
    }

    public void showSelfData(Admin admin)//parameter is the admin that is logged in and want to see his data
    {
        Console.WriteLine($"ID: {admin.ID}, Name: {admin.Name}, Email: {admin.Email}, Phone Number: {admin.PhoneNumber}, Address: {admin.Address.Street}, {admin.Address.City}, {admin.Address.Country}, {admin.Address.PostalCode}");
    }
}

