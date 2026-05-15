public interface IAdminServiceOnLocation
{

    //function related to location
    public void AddLocation(string locationCode, string locationName, string locationType);
    public void RemoveLocation(string locationCode);
    public void changeLocationName(string locationCode, string newLocationName);
    public void changeLocationBuilding(string locationCode, string newLocationBuilding);
    public void showAllLocations();
    public void showLocationData(string locationCode);

}