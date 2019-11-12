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
    public class ClinicsController : ControllerBase
    {
        private readonly EFDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _env;

        public ClinicsController(IHostingEnvironment env,
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
            var model = _context.Clinics.Select(
                p => new ClinicVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    City= p.City.Name,
                    Street = p.Street

                }).ToList();
            return Ok(model);
        }


        [HttpPost]
        public IActionResult Create([FromBody]ClinicAddVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Clinic m = new Clinic
            {
                Name = model.Name
            };
            _context.Clinics.Add(m);
            _context.SaveChanges();
            return Ok(m.Id);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]ClinicDeleteVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var type = _context.Clinics.SingleOrDefault(p => p.Id == model.Id);
            if (type != null)
            {
                _context.Clinics.Remove(type);
                _context.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody]ClinicVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var prod = _context.Clinics.SingleOrDefault(p => p.Id == model.Id);
            if (prod != null)
            {
                prod.Name = model.Name;
                _context.SaveChanges();
            }
            return Ok();
        }
    }
}