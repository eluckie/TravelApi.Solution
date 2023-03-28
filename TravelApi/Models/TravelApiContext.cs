using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Place> Places { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Place>()
        .HasData(
          new Place { PlaceId = 1, City = "San Francisco", State = "California", Country = "USA", SeasonVisited = "spring", Rating = 4, Review = "I love visiting the city in the spring", User_Name = "Luckie"},

          new Place { PlaceId = 2, City = "San Diego", State = "California", Country = "USA", SeasonVisited = "summer", Rating = 5, Review = "Gorgeous in the summer", User_Name = "Luckie"},
          new Place { PlaceId = 3, City = "Las Vegas", State = "Nevada", Country = "USA", SeasonVisited = "summer", Rating = 2, Review = "I was not a fan of Vegas", User_Name = "Luckie"},
          new Place { PlaceId = 4, City = "Grand Canyon Village", State = "Arizona", Country = "USA", SeasonVisited = "summer", Rating = 5, Review = "Most beautiful place I've ever seen", User_Name = "Luckie"},
          new Place { PlaceId = 5, City = "Cleveland", State = "Ohio", Country = "USA", SeasonVisited = "winter", Rating = 3, Review = "City itself so-so, amazing people", User_Name = "Luckie"}
        );
    }
  }
}