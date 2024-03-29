using Microsoft.AspNetCore.Mvc;
using MW_Assignment_4.Entities;

namespace MW_Assignment_4.Repositories
{
    public interface IAddAirport
    {
        public Task<List<Airports>> GetAirportInfo(int airportId)
        public Task<int>> AddAirports(Airports airports);

    }
}
