using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDLL.Interfaces
{
    public interface ICityService
    {
        List<CityModel> GetCities();
        Task<List<CityModel>> GetCitiesAsync();
        int CreateCity(CityModel city);
    }
}
