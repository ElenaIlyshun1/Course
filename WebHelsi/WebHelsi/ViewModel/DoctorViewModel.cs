using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.ViewModel
{
    public class DoctorVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Spetialization { get; set; }
        public string Clinic { get; set; }
        public string City { get; set; }
        public DateTime DateBirthday { get; set; }
        public string ImageDoctor { get; set; }
        public string Email { get; set; }
    }
    public class DoctorAddVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Spetialization { get; set; }
        public string Clinic { get; set; }
        public string City { get; set; }
        public DateTime DateBirthday { get; set; }
        public string ImageDoctor { get; set; }
        public string Email { get; set; }
    }
    public class DoctorDeleteVM
    {
        public int Id { get; set; }
    }
}
