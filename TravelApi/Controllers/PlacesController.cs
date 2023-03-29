using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PlacesController : ControllerBase
  {
    private readonly TravelApiContext _db;

    public PlacesController(TravelApiContext db)
    {
      _db = db;
    }

    // GET api/Places
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Place>>> Get(int rating, int minimumRating, bool rec, string city, string state, string country)
    {
      IQueryable<Place> query = _db.Places.AsQueryable();

      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      if (minimumRating > 0)
      {
        query = query.Where(entry => entry.Rating >= minimumRating);
      }

      if (rec)
      {
        query = query.Where(entry => entry.Rating >= 4);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }

      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      return await query.ToListAsync();
    }

    // GET api/Places/3
    [HttpGet("{id}")]
    public async Task<ActionResult<Place>> GetPlace(int id)
    {
      Place place = await _db.Places.FindAsync(id);

      if (place == null)
      {
        return NotFound();
      }

      return place;
    }

    // POST api/Places
    [HttpPost]
    public async Task<ActionResult<Place>> Post(Place place)
    {
      _db.Places.Add(place);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPlace), new { id = place.PlaceId }, place);
    }

    // PUT api/Places/3
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Place place)
    {
      if (id != place.PlaceId)
      {
        return BadRequest();
      }
      _db.Places.Update(place);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PlaceExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    private bool PlaceExists(int id)
    {
      return _db.Places.Any(entry => entry.PlaceId == id);
    }

    // DELETE api/Places/3
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePlace(int id)
    {
      Place place = await _db.Places.FindAsync(id);
      if (place == null)
      {
        return NotFound();
      }
      _db.Places.Remove(place);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}