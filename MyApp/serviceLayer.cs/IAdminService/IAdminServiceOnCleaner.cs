public interface IAdminServiceOnCleaner
{
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

}