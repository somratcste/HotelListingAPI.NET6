using HotelListing.API.Core.Client.Country;
using HotelListing.API.Models;

namespace HotelListing.API.Core.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
