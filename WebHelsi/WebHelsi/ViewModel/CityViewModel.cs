using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.ViewModel
{

    public class CityVM
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
