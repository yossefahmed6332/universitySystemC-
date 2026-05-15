public class AdminServiceOnAddress : IAdminServiceOnAddress
{

    //methods related to address
    public void AddAddress(string id, string street, string city, string state, string postalCode,string country)    {
        try
        {
            Address address = new Address(id, street, city, state, country, postalCode);
            Address.Addresses.Add(address);
            Console.WriteLine("Address added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void RemoveAddress(string id)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            Address.Addresses.Remove(address);
            address = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Address removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeStreet(string id, string newStreet)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            address.Street = newStreet;
            Console.WriteLine("Street changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeCity(string id, string newCity)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            address.City = newCity;
            Console.WriteLine("City changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changePostalCode(string id, string postalCode)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            address.PostalCode = postalCode;
            Console.WriteLine("Postal code changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changecountry(string id, string newCountry)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            address.Country = newCountry;
            Console.WriteLine("Country changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void showAllAddresses()
    {
        if (Address.Addresses.Count == 0)
        {
            Console.WriteLine("No addresses found");
            return;
        }
        foreach (Address address in Address.Addresses)
        {
            Console.WriteLine($"ID: {address.ID}, Street: {address.Street}, City: {address.City}, Postal Code: {address.PostalCode}, Country: {address.Country}");
        }
    }

    public void showAddressData(string id)
    {
        try
        {
            Address? address = Address.Addresses.FirstOrDefault(a => a.ID == id);
            if (address == null)
            {
                throw new Exception("Address not found");
            }
            Console.WriteLine($"ID: {address.ID}, Street: {address.Street}, City: {address.City}, Postal Code: {address.PostalCode}, Country: {address.Country}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}