using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.Entities
{
    [Table("tblDoctors")]
    public class ListDoctors
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Spetialization { get; set; }
        public DateTime DateBirthday { get; set; }
        public string ImageDoctor { get; set; }

        [ForeignKey("Cities")]
        public int CitiesId { get; set; }
        public virtual Cities City { get; set; }

        [ForeignKey("Clinic")]
        public int ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; }

        [ForeignKey("Specialization")]
        public int SpecializationId { get; set; }
        public virtual Specialization Specialization { get; set; }

        [ForeignKey("Clients")]
        public int ClientsId { get; set; }
        public virtual Clients Clients { get; set; }
    }
}
