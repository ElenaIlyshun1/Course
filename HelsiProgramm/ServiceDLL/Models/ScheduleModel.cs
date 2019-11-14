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
        public int IdDoctor { get; set; }
        public int IdClient { get; set; }


    }

    public class ScheduleAddModel
    {
        public DateTime ScheduleDateIn { get; set; }
        public int IdDoctor { get; set; }
        public int IdClient { get; set; }
    }
}
