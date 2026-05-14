
public class HelperFunctions
{

//function to generate unique ID for all models , the list in Faculty class in used
    public static string GenerateID()
    {
            Random random = new Random();
            string id = random.Next(100000, 999999).ToString();//create random 6 digit number as ID
            if (Faculty.IDList1.Contains(id))//
            {
                return GenerateID();
            }
            return id;
        }        

    public static Address getAddressByID(string id)
    {
        foreach (Address address in Address.Addresses)
        {
            if (address.ID == id)
            {
                return address;
            }
        }
        return null;
    }
    //get address by its data 
    public static Address getAddressByData(string country, string city, string street, string buildingNumber, string postalCode)
    {
        foreach (Address address in Address.Addresses)
        {
            if (address.Country == country && address.City == city && address.Street == street && address.BuildingNumber == buildingNumber && address.PostalCode == postalCode)
            {
                return address;
            }
        }
        return null;
    }

}