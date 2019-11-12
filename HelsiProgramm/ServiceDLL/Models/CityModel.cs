using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDLL.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
    }
    public class CityAddVM
    {
        public string Name { get; set; }
      
    }
    public class CityDeleteVM
    {
        public int Id { get; set; }
    }
}
