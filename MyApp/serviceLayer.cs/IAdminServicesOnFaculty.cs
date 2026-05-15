public interface IAdminServiceOnFaculty
{
    //function related to faculty
    public void addFaculty(string facultyCode, string facultyName);
    public void removeFaculty(string facultyCode);
    public void changeFacultyName(string facultyCode, string newFacultyName);
    public void changeFacultyDepartments(string facultyCode, List<Department> newDepartments);
    public void addDepartmentToFaculty(string facultyCode, Department department);
    public void removeDepartmentFromFaculty(string facultyCode, Department department);
    public void showAllFaculties(string ID);
    public void showFacultyData(string ID);
}