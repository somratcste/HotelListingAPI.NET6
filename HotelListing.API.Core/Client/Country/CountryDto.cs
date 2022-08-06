using HotelListing.API.Core.Client.Hotel;

namespace HotelListing.API.Core.Client.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
