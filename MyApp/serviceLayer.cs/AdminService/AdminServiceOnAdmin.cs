public class AdminServiceOnAdmin : IAdminServiceOnAdmin
{



    //methods related to admin
    public void addAdmin(string id, string name, string email, string password, string phoneNumber, string addressID)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == addressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            Admin admin = new Admin(id, name, email, password, phoneNumber, address);
            Console.WriteLine("Admin added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changePhoneNumber(string id, string newPhoneNumber)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID1 == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            admin.PhoneNumber = newPhoneNumber;
            Console.WriteLine("Phone number changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeEmail(string id, string newEmail)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID1 == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            admin.Email = newEmail;
            Console.WriteLine("Email changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void changePassword(string id, string newPassword)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID1 == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            admin.Password = newPassword;
            Console.WriteLine("Password changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public void changeAddress(string id, string newAddressID)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID1 == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == newAddressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            admin.Address = address;
            Console.WriteLine("Address changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void RemoveAdmin(string id)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID1 == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            Admin.Admins.Remove(admin);
            admin = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Admin removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void showAllAdmins()
    {
        if (Admin.Admins.Count == 0)
        {
            Console.WriteLine("No admins found");
            return;
        }
        foreach (Admin admin in Admin.Admins)
        {
            Console.WriteLine($"ID: {admin.ID1}, Name: {admin.Name}, Email: {admin.Email}, Phone Number: {admin.PhoneNumber}, Address: {admin.Address.Street}, {admin.Address.City}, {admin.Address.Country}, {admin.Address.PostalCode}, Country: {admin.Address.Country}");
        }
    }
    public void showAdminData(string id)
    {
        try
        {
            Admin? admin = Admin.Admins.FirstOrDefault(a => a.ID1 == id);
            if (admin == null)
            {
                throw new Exception("Admin not found");
            }
            Console.WriteLine($"ID: {admin.ID1}, Name: {admin.Name}, Email: {admin.Email}, Phone Number: {admin.PhoneNumber}, Address: {admin.Address.Street}, {admin.Address.City}, {admin.Address.Country}, {admin.Address.PostalCode}, Country: {admin.Address.Country}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}