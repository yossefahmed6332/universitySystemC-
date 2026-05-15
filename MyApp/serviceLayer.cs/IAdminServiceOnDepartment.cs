public interface IAdminServiceOnDepartment
{
    //function related to department
    public void addDepartment(string departmentCode, string departmentName);
    public void removeDepartment(string departmentCode);
    public void changeDepartmentName(string departmentCode, string newDepartmentName);
    public void changeDepartmentCourses(string departmentCode, List<Course> newCourses);
    public void changeDepartmentTeachers(string departmentCode, List<Teacher> newTeachers);
    public void addTeacherToDepartment(string departmentCode, string teacherID);
    public void removeTeacherFromDepartment(string departmentCode, string teacherID);
    public void addCourseToDepartment(string departmentCode, string courseID);
    public void removeCourseFromDepartment(string departmentCode, string courseID);
    public void showAllCoursesInDepartment(string departmentCode);
    public void showAllDepartments();
    public void showDepartmentData(string ID);

}