﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.ViewModel
{
    public class ClinicVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
    public class ClinicAddVM
    {      
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
    public class ClinicDeleteVM
    {
        public int Id { get; set; }
       
    }
}
