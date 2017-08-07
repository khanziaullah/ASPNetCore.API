using ASPNetCore.API.Model;
using System.Collections.Generic;

namespace ASPNetCore.API
{
    public class CitiesDataSource
    {
        public static CitiesDataSource Current = new CitiesDataSource();

        public List<CityDto> Cities;

        public CitiesDataSource()
        {
            Cities = new List<CityDto>
            {
                new CityDto { Id = 1, Name = "New York", Description = "", NumberOfTouristSpots = 20},
                new CityDto { Id = 2, Name = "Columbus", Description = "", NumberOfTouristSpots = 2},
                new CityDto { Id = 3, Name = "Chicago", Description = "", NumberOfTouristSpots = 10},
            };
        }
    }
}
