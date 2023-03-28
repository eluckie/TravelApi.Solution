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
    public async Task<ActionResult<IEnumerable<Place>>> Get()
    {
      return await _db.Places.ToListAsync();
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
  }
}