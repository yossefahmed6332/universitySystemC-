public interface IAdminServiceOnCourse
{
    
    //function related to course 
    public void addCourse(string ID, string name, int creditHours, string department);
    public void removeCourse(string ID);
    public void changeCourseName(string ID, string newName);
    public void changeCourseCreditHours(string ID, int newCreditHours);
    public void changeCourseDepartment(string ID, string newDepartment);
    public void showAllCourses();
    public void showCourseData(string id);

}