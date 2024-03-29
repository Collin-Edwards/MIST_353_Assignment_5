using Microsoft.AspNetCore.Mvc;
using MW_Assignment_4.Entities;
using MW_Assignment_4.Repositories;

namespace MW_Assignment_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportsController : Controller
    {
        private readonly IGetAirportInfo getAirportInfo;
        public AirportsController(IGetAirportInfo getairportinfo)
        {
            this.getAirportInfo = getairportinfo;
        }
        [HttpGet("{airportid}")]

        public async Task<List<Airports>> GetAirportInfo(int airportId)
        {
            var airportInfo = await getAirportInfo.GetAirportInfo(airportId);
            if (airportInfo == null)
            {
                return NotFound();
            }
            return airportInfo;
        }
        [HttpPost("add")]
        public async Task<ActionResult<int>> AddAirports(Airports airports)
        {
            var airportDetails = await AddAirport.AddAirport(airports);
            if (airportDetails == null)
            {
                return NotFound();

            }
            return airportDetails;
        }

        


        }
    }
}
