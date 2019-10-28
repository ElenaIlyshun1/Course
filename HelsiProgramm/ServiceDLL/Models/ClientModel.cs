using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceDLL.Models
{
    public class ClientModel
    {
        public class ClientViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime DateBirthday { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class ClinicModels
        {
            public int Id { get; set; }
            public string Name { get; set; }
            //public string City { get; set; }
            public string Street { get; set; }

        }

        public class DoctorViewModel
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

        public class LoginViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
