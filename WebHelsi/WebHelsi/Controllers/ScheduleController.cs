using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebHelsi.Entities;
using WebHelsi.ViewModel;

namespace WebHelsi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly EFDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _env;

        public ScheduleController(IHostingEnvironment env,
            IConfiguration configuration,
            EFDbContext context)
        {
            _configuration = configuration;
            _env = env;
            _context = context;
        }
        [HttpGet]
        public IActionResult MakeList()
        {
            var model = _context.Schedules.Select(
                p => new ScheduleViewModel
                {
                    Id = p.Id,
                    ScheduleDateIn = p.ScheduleDateIn
                }).ToList();
            return Ok(model);
        }


        [HttpPost]
        public IActionResult Create([FromBody]ScheduleAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Schedule sch = new Schedule
            {
                ScheduleDateIn = model.ScheduleDateIn,
                ClientId = model.IdClient,
                DoctorId = model.IdDoctor                
            };
            _context.Schedules.Add(sch);
            _context.SaveChanges();
            return Ok(sch.Id);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]ScheduleDeleteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var sch = _context.Schedules.SingleOrDefault(p => p.Id == model.Id);
            if (sch != null)
            {
                _context.Schedules.Remove(sch);
                _context.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody]ScheduleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var sch = _context.Schedules.SingleOrDefault(p => p.Id == model.Id);
            if (sch != null)
            {
                sch.ScheduleDateIn = model.ScheduleDateIn;
                _context.SaveChanges();
            }
            return Ok();
        }
    }
}