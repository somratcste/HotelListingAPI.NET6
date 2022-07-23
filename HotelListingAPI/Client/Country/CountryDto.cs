using HotelListingAPI.Client.Hotel;

namespace HotelListingAPI.Client.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
