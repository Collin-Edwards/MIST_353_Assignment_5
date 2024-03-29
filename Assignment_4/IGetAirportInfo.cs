using System.Threading.Tasks;
using MW_Assignment_4.Entities;
using MW_Assignment_4.Data;

namespace MW_Assignment_4.Repositories
{
    public interface IGetAirportInfo
    {
        public Task<List<Airports>> GetAirportInfo(int airportId)
    }
}
