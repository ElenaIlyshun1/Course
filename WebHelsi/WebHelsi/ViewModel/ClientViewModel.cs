using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.ViewModel
{
    public class ClientVM
    {
        public int Id { get; set; }      
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateBirthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ClientAddVM
    {     
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateBirthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ClientDeleteVM
    {
        public int Id { get; set; }      
    }
}
