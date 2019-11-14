using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDLL.Models
{
    public class ScheduleModel
    {
        public int Id { get; set; }
        public DateTime ScheduleDateIn { get; set; }
        public int DoctorId { get; set; }
        public int ClientId { get; set; }


    }

    public class ScheduleAddModel
    {
        public DateTime ScheduleDateIn { get; set; }
        public int DoctorId { get; set; }
        public int ClientId { get; set; }
    }
}
