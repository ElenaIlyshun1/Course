using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.ViewModel
{
   
    public class SpecializationVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class SpecializationAddVM
    {
        public string Name { get; set; }

    }
    public class SpecializationDeleteVM
    {
        public int Id { get; set; }
    }

}
