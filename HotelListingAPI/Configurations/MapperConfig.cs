using AutoMapper;
using HotelListingAPI.Client.Country;
using HotelListingAPI.Data;

namespace HotelListingAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
           
        }
    }
}
