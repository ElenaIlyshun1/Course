﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.ViewModel
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }
        public DateTime ScheduleDateIn { get; set; }
        public int DoctorId { get; set; }
        public int ClientId { get; set; }
    }

    public class ScheduleAddViewModel
    {
        public DateTime ScheduleDateIn { get; set; }
        public int DoctorId { get; set; }
        public int ClientId { get; set; }
    }

    public class ScheduleDeleteViewModel
    {
        public int Id { get; set; }
    }
}
