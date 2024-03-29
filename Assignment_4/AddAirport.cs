using MW_Assignment_4.Data;
using MW_Assignment_4.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;


namespace MW_Assignment_4.Repositories
{
    public class AddAirport : IAddAirport
    {
        private readonly DbContextClass _dbContextClass;
        public AddAirport(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
       
        public async Task<int>> AddAirports(Airports airports)
        {
            var airportID = new SqlParameter("@airportID", airports.airportid);
            var airportName = new SqlParameter("@airportName", airports.name);
            var airportLocation = new SqlParameter("@airportLocation", airports.location);
            var airporticaocode = new SqlParameter("@airportICAO", airports.icaocode);
            var airportmilitarystatus = new SqlParameter("airportMilitaryStatus", airports.ismilitary);

            var airportDetails = await Task.Run(() => _dbContext.Database.ExecuteSqlRaw(_dbContextClass.Database.ExecuteSqlRaw("spAddAirport, @airportID, @airportName, @airportLocation, @airportICAO, @airportMilitaryStatus");
            return airportDetails;
        }

    }
}
