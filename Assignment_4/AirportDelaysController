using Microsoft.AspNetCore.Mvc;
using 

namespace AirportDelaysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportDelaysController : ControllerBase
    {
        private readonly IAirpoerDelays AirportDelays;

        public AirportDelaysController(YourDbContext context)
        {
            _AirportDelays = AirportDelays;
        }

        [HttpGet("{airportId}")]
        public async Task<ActionResult<IEnumerable<AirportDelay>>> GetAirportDelays(int airportId)
        {
            var delays = await _context.AirportDelays
                .Where(d => d.AirportId == airportId)
                .ToListAsync();

            if (delays == null)
            {
                return NotFound();
            }

            return delays;
        }
    }
}
