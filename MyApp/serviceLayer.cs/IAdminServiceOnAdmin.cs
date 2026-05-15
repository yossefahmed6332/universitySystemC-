public interface IAdminServiceOnAdmin
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

}