namespace TravelApi.Models
{
  public class Place
  {
    public int PlaceId { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string SeasonVisited { get; set; }
    public int Rating { get; set; }
    public string Review { get; set; }
    public string User_Name { get; set; }
  }
}