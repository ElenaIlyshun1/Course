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
    public class SpecializationsController : ControllerBase
    {
        private readonly EFDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _env;

        public SpecializationsController(IHostingEnvironment env,
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
            var model = _context.Specializations.Select(
                p => new SpecializationVM
                {
                    Id = p.Id,
                    Name = p.Name
                     
                }).ToList();
            return Ok(model);
        }


        [HttpPost]
        public IActionResult Create([FromBody]SpecializationAddVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Specialization m = new Specialization
            {
                Name = model.Name
            };
            _context.Specializations.Add(m);
            _context.SaveChanges();
            return Ok(m.Id);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]SpecializationDeleteVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var type = _context.Specializations.SingleOrDefault(p => p.Id == model.Id);
            if (type != null)
            {
                _context.Specializations.Remove(type);
                _context.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody]SpecializationVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var prod = _context.Specializations.SingleOrDefault(p => p.Id == model.Id);
            if (prod != null)
            {
                prod.Name = model.Name;
                _context.SaveChanges();
            }
            return Ok();
        }
    }
}