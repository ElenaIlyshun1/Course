using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDLL.Interfaces
{
    interface IScheduleService
    {
        List<ScheduleModel> GetSchedule();
        Task<List<ScheduleModel>> GetScheduleAsync();
        string CreateSchedule(ScheduleAddModel schedule);
    }
}
