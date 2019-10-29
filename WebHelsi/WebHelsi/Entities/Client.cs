using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.Entities
{
    [Table("tblClients")]
    public class Client
    {
        [Key, ForeignKey("User")]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateBirthday { get; set; }

        public virtual DbUser User { get; set; }


    }
}
