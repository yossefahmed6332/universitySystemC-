public interface IAdminService
{
    //functions related to admin
    public void AddAdmin(string id, string name, string email, string password, string phoneNumber, string addressID);
    public void changePhoneNumber(string id, string newPhoneNumber);
    public void changeEmail(string id, string newEmail);
    public void changePassword(string id, string newPassword);
    public void changeAddress(string id, string newAddressID);
    public void RemoveAdmin(string id);
    public void showAllAdmins();
    public void showAdminData(string ID);

    
    //functions related to Address 
    public void AddAddress(string id, string street, string city, string state, string postalCode,string country);
    public void RemoveAddress(string id);
    public void changeStreet(string id, string newStreet);
    public void changeCity(string id, string newCity);
    public void changecountry(string id, string newCountry);
    public void changePostalCode(string id, string postalCode);
    public void showAddressData(string id);

    
    public void showAllAddresses();

    //function related to cleaner 
    public void AddCleaner(string id, string name, string email, string password, string phoneNumber, string addressID, double salaryPerHour, string hoursOfWork, string locationID);
    public void RemoveCleaner(string id);
    public void changeCleanerPhoneNumber(string id, string newPhoneNumber);
    public void changeCleanerEmail(string id, string newEmail);
    public void changeCleanerPassword(string id, string newPassword);
    public void changeCleanerAddress(string id, string newAddressID);
    public void changeCleanerSalary(string id, double newSalary);
    public void changeCleanerHoursOfWork(string id, string newHoursOfWork);
    public void changeCleanerLocation(string id, string newLocationID);
    public void showAllCleaners();
    public void showCleanerData(string id);

    //function related to course 
    public void addCourse(string ID, string name, int creditHours, string department);
    public void removeCourse(string ID);
    public void changeCourseName(string ID, string newName);
    public void changeCourseCreditHours(string ID, int newCreditHours);
    public void changeCourseDepartment(string ID, string newDepartment);
    public void showAllCourses();
    public void showCourseData(string id);

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


    //function related to faculty
    public void addFaculty(string facultyCode, string facultyName);
    public void removeFaculty(string facultyCode);
    public void changeFacultyName(string facultyCode, string newFacultyName);
    public void changeFacultyDepartments(string facultyCode, List<Department> newDepartments);
    public void addDepartmentToFaculty(string facultyCode, Department department);
    public void removeDepartmentFromFaculty(string facultyCode, Department department);
    public void showAllFaculties(string ID);
    public void showFacultyData(string ID);

    //function related to location
    public void AddLocation(string locationCode, string locationName, string locationType);
    public void RemoveLocation(string locationCode);
    public void changeLocationName(string locationCode, string newLocationName);
    public void changeLocationBuilding(string locationCode, string newLocationBuilding);
    public void showAllLocations();
    public void showLocationData(string locationCode);

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