public interface IAdminServiceOnStudent
{

    //function related to student 
    public void addStudent(string id, string name, string email, string password, string phoneNumber, string departmentID, string addressID);
    public void removeStudent(string id);
    public void changeStudentPhoneNumber(string id, string newPhoneNumber);
    public void changeStudentEmail(string id, string newEmail);
    public void changeStudentPassword(string id, string newPassword);
    public void changeStudentAddress(string id, string newAddressID);
    public void changeStudentGPA(string id, double newGPA);
    public void changeStudentCourses(string id, List<Course> newCourses);
    public void changeStudentDepartment(string id, string DepartmentID);
    public void changeStudentGrades(string id, List<string> newGrades);
    public void showAllStudents();
    public void showStudentData(string id);
}