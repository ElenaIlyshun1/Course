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
    //[Route("api/[controller]")]
    //[ApiController]
    //public class DoctorsController : ControllerBase
    //{
    //    private readonly EFDbContext _context;
    //    private readonly IConfiguration _configuration;
    //    private readonly IHostingEnvironment _env;

    //    public DoctorsController(IHostingEnvironment env,
    //        IConfiguration configuration,
    //        EFDbContext context)
    //    {
    //        _configuration = configuration;
    //        _env = env;
    //        _context = context;
    //    }
    //    [HttpGet]
    //    public IActionResult MakeList()
    //    {
    //        var model = _context.Doctors.Select(
    //            p => new DoctorVM
    //            {
    //                Id = p.Id,
    //                Name = p.Name,
    //                Surname = p.Surname,
    //                DateBirthday = p.DateBirthday,
    //                ImageDoctor = p.ImageDoctor,
                  
    //            }).ToList();
    //        return Ok(model);
    //    }


    //    [HttpPost]
    //    public IActionResult Create([FromBody]DoctorAddVM model)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }
    //        Doctor m = new Doctor
    //        {
    //            Name = model.Name
    //        };
    //        _context.Doctors.Add(m);
    //        _context.SaveChanges();
    //        return Ok(m.Id);
    //    }

    //    [HttpDelete]
    //    public IActionResult Delete([FromBody]DoctorDeleteVM model)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }
    //        var type = _context.Doctors.SingleOrDefault(p => p.Id == model.Id);
    //        if (type != null)
    //        {
    //            _context.Doctors.Remove(type);
    //            _context.SaveChanges();
    //        }
    //        return Ok();
    //    }
    //    [HttpPut]
    //    public IActionResult Update([FromBody]DoctorVM model)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }
    //        var prod = _context.Doctors.SingleOrDefault(p => p.Id == model.Id);
    //        if (prod != null)
    //        {
    //            prod.Name = model.Name;
    //            _context.SaveChanges();
    //        }
    //        return Ok();
    //    }
    //}
}