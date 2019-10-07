using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.Entities
{
    [Table("tblCities")]
    public class Cities
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }

        [ForeignKey("Clinic")]
        public int ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; }

        [ForeignKey("ListDoctors")]
        public int ListDoctorsId { get; set; }
        public virtual ListDoctors ListDoctors { get; set; }

    }
}
