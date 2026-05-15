public interface IAdminServiceOnTeacher
{
    //function related to teacher
    public void addTeacher(string id, string name, string email, string password, string phoneNumber, string addressID, double salaryPerHour, string hoursOfWork, string officeNumber, string role);
    public void removeTeacher(string id);
    public void changeTeacherPhoneNumber(string id, string newPhoneNumber);
    public void changeTeacherEmail(string id, string newEmail);
    public void changeTeacherPassword(string id, string newPassword);
    public void changeTeacherAddress(string id, string newAddressID);
    public void changeTeacherSalary(string id, double newSalary);
    public void changeTeacherHoursOfWork(string id, string newHoursOfWork);
    public void changeTeacherCourses(string id, List<Course> newCourses);
    public void changeTeacherOfficeNumber(string id, string newOfficeNumber);
    public void changeTeacherRole(string id, string newRole);
    public void ShowAllTeachers();
    public void showSelfData(Admin admin);
    public void showTeacherData(string id);




}