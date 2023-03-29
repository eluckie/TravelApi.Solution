using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Place
  {
    public int PlaceId { get; set; }
    [Required]
    [StringLength(20)]
    public string City { get; set; }
    [StringLength(20)]
    public string State { get; set; }
    [Required]
    [StringLength(20)]
    public string Country { get; set; }
    [StringLength(7, ErrorMessage = "Review only one season at a time please.")]
    public string SeasonVisited { get; set; }
    [Required]
    [Range(0, 5, ErrorMessage = "Rating must be between 1 and 5, 5 being the highest.")]
    public int Rating { get; set; }
    [Required]
    public string Review { get; set; }
    [Required]
    [StringLength(25)]
    public string User_Name { get; set; }
  }
}