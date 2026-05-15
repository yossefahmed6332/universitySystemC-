public class AdminServicesOnCleaner : IAdminServiceOnCleaner
{
  

    //methods related to cleaner
    public void AddCleaner(string id, string name, string email, string password, string phoneNumber, string addressID, double salaryPerHour, string hoursOfWork, string locationID)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == addressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationID);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            Cleaner cleaner = new Cleaner(id, name, email, password, phoneNumber, address, salaryPerHour, hoursOfWork, location);
            Cleaner.Cleaners.Add(cleaner);
            Console.WriteLine("Cleaner added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void RemoveCleaner(string id)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            Cleaner.Cleaners.Remove(cleaner);
            cleaner = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Cleaner removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerPhoneNumber(string id, string newPhoneNumber)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.PhoneNumber = newPhoneNumber;
            Console.WriteLine("Cleaner phone number changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerEmail(string id, string newEmail)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.Email = newEmail;
            Console.WriteLine("Cleaner email changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerPassword(string id , string newPassword)

    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.Password = newPassword;
            Console.WriteLine("Cleaner password changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerAddress(string id, string newAddressID)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == newAddressID);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            cleaner.Address = address;
            Console.WriteLine("Cleaner address changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCleanerSalary(string id, double newSalary)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.SalaryPerHour = newSalary;
            Console.WriteLine("Cleaner salary changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void changeCleanerHoursOfWork(string id, string newHoursOfWork)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            cleaner.HoursOfWork = newHoursOfWork;
            Console.WriteLine("Cleaner hours of work changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public void changeCleanerLocation(string id, string newLocationID)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == newLocationID);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            cleaner.Location1 = location;
            Console.WriteLine("Cleaner location changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    
    }
    public void showAllCleaners()
    {
        if (Cleaner.Cleaners.Count == 0)
        {
            Console.WriteLine("No cleaners found");
            return;
        }
        foreach (Cleaner cleaner in Cleaner.Cleaners)
        {
            Console.WriteLine($"ID: {cleaner.ID}, Name: {cleaner.Name}, Email: {cleaner.Email}, Phone Number: {cleaner.PhoneNumber}, Address: {cleaner.Address.Street}, {cleaner.Address.City}, {cleaner.Address.PostalCode}, Salary Per Hour: {cleaner.SalaryPerHour}, Hours Of Work: {cleaner.HoursOfWork}, Location: {cleaner.Location1.Building}, {cleaner.Location1.Floor}");
        }
    }

    public void showCleanerData(string id)
    {
        try
        {
            Cleaner? cleaner = Cleaner.Cleaners.FirstOrDefault(c => c.ID == id);
            if (cleaner == null)
            {
                throw new Exception("Cleaner not found");
            }
            Console.WriteLine($"ID: {cleaner.ID}, Name: {cleaner.Name}, Email: {cleaner.Email}, Phone Number: {cleaner.PhoneNumber}, Address: {cleaner.Address.Street}, {cleaner.Address.City}, {cleaner.Address.PostalCode}, Salary Per Hour: {cleaner.SalaryPerHour}, Hours Of Work: {cleaner.HoursOfWork}, Location: {cleaner.Location1.Building}, {cleaner.Location1.Floor}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }}


}