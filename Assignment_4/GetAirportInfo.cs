using MW_Assignment_4.Data;
using MW_Assignment_4.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using MW_Assignment_4.Repositories;

namespace MW_Assignment_4.Repositories
{
    public class GetAirportInfo
    {
    }
}

public class GetAirportInfo : IGetAirportInfo
{
    private readonly DbContextClass _dbcontext;
    public GetAirportInfo(DbContextClass dbcontext)
    {
        _dbcontext = dbcontext;

    }
    public async Task<List<Airports>> GetAirportInfo(int airportId)
    {
        var airportID = new SqlParameter("@airportID", airportId);
        var airportInfo = await Task.Run(() =>_dbcontext.Airports.FromSqlRaw("spGetAirportInformation @airportID", airportID).ToListAsync());
        return airportInfo;
    }


}