public class AdminServicesOnLocation : IAdminServiceOnLocation
{
    
    //methods related to location
    public void AddLocation(string locationCode, string locationName, string locationType)
    {
        try
        {
            Location location = new Location(locationCode, locationName, locationType);
            Location.Locations.Add(location);
            Console.WriteLine("Location added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void RemoveLocation(string locationCode)
    {
        try
        {
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationCode);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            Location.Locations.Remove(location);
            location = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Location removed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeLocationName(string locationCode, string newLocationName)
    {
        try
        {
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationCode);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            location.Building = newLocationName;
            Console.WriteLine("Location name changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void changeLocationBuilding(string locationCode, string newLocationBuilding)
    {
        try
        {
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationCode);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            location.Building = newLocationBuilding;
            Console.WriteLine("Location building changed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void showAllLocations()
    {
        if (Location.Locations.Count == 0)
        {
            Console.WriteLine("No locations found");
            return;
        }
        foreach (Location location in Location.Locations)
        {
            Console.WriteLine($"ID: {location.ID1}, Name: {location.Building}, Type: {location.Floor}");
        }
    }
    public void showLocationData(string locationCode)
    {
        try
        {
            Location? location = Location.Locations.FirstOrDefault(l => l.ID1 == locationCode);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            Console.WriteLine($"ID: {location.ID1}, Name: {location.Building}, Type: {location.Floor}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}