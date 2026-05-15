public class AdminServicesOnFaculty : IAdminServiceOnFaculty
{

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
    public void showFacultyData(string ID)
    {
        try
        {
            Faculty? faculty = Faculty.Faculties.FirstOrDefault(u => u.ID1 == ID);
            if (faculty == null)
            {
                throw new Exception("Faculty not found");
            }
            Console.WriteLine($"ID: {faculty.ID1}, Name: {faculty.Name}, Departments: {string.Join(", ", faculty.Departments.Select(d => d.name1))}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}