using System.Runtime.CompilerServices;

public class Address
{
    private string country;
    private string city;
    private string street;
    private string buildingNumber;
    private string postalCode;
    private string addressID;

    private static List <Address> addresses = new List<Address>();
    public Address(string ID,string country, string city, string street, string buildingNumber, string postalCode)
    {
        this.country = country;
        this.city = city;
        this.street = street;
        this.buildingNumber = buildingNumber;
        this.postalCode = postalCode;
        this.addressID=ID;
        addresses.Add(this);
    }

    //setters and getters
    public string Country { get => country; set => country = value; }
    public string City { get => city; set => city = value; }
    public string Street { get => street; set => street = value; }
    public string BuildingNumber { get => buildingNumber; set => buildingNumber = value; }
    public string PostalCode { get => postalCode; set => postalCode = value; }
    public string ID{get=>addressID; set=>addressID=value;}
    

    public static List<Address> Addresses { get => addresses; set => addresses = value; }

    
    
}