using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNetCore.API.Model;

namespace ASPNetCore.API.Controller
{
    [Route("api/cities")]
    public class CitiesController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public List<CityDto> GetCities()
        {
            return CitiesDataSource.Current.Cities;
        }

        [HttpGet("{id}")]
        public CityDto GetCity(int id)
        {
            return CitiesDataSource.Current.Cities.Where(x=> x.Id == id).First();
        }
    }
}
