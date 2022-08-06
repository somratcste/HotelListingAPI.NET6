using HotelListing.API.Client.Hotel;

namespace HotelListing.API.Client.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
