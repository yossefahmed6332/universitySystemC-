public interface ITeacherService
{
    //functions related to teacher
    public void gradeStudent(Student std, string courseCode, string grade);
    public void showAllCourses(Teacher teacher);
    
}
