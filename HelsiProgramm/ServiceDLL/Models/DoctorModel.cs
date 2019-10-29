using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDLL.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Spetialization { get; set; }
        public string Clinic { get; set; }
        public string City { get; set; }
        public DateTime DateBirthday { get; set; }
        public string ImageDoctor { get; set; }

    }
}
