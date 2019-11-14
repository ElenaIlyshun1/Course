using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.Entities
{

    [Table("tblSchedule")]
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 250)]
        public DateTime ScheduleDateIn { get; set; }
       // public DateTime ScheduleDateOut { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    //-------------------------------------------------
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
