public class Location
{
    private string building ; 
    private string floor ;
    public static List <Location> locations = new List<Location>();

    public Location(string building, string floor)
    {
        this.building = building;
        this.floor = floor;
        locations.Add(this);
    }

}