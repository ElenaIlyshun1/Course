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
    //[Authori]
    //[Route("api/[controller]")]
    //[ApiController]
    //public class CitiesController : ControllerBase
    //{
    //    private readonly EFDbContext _context;
    //    private readonly IConfiguration _configuration;
    //    private readonly IHostingEnvironment _env;

    //    public CitiesController(IHostingEnvironment env,
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
    //        var model = _context.Cities.Select(
    //            p => new CityVM
    //            {
    //                Id = p.Id,
    //                Name = p.Name
                     

    //            }).ToList();
    //        return Ok(model);
    //    }


    //    [HttpPost]
    //    public IActionResult Create([FromBody]CityAddVM model)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }
    //        City m = new City
    //        {
    //            Name = model.Name
    //        };
    //        _context.Cities.Add(m);
    //        _context.SaveChanges();
    //        return Ok(m.Id);
    //    }

    //    [HttpDelete]
    //    public IActionResult Delete([FromBody]CityDeleteVM model)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }
    //        var type = _context.Cities.SingleOrDefault(p => p.Id == model.Id);
    //        if (type != null)
    //        {
    //            _context.Cities.Remove(type);
    //            _context.SaveChanges();
    //        }
    //        return Ok();
    //    }
    //    [HttpPut]
    //    public IActionResult Update([FromBody]CityVM model)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }
    //        var prod = _context.Cities.SingleOrDefault(p => p.Id == model.Id);
    //        if (prod != null)
    //        {
    //            prod.Name = model.Name;
    //            _context.SaveChanges();
    //        }
    //        return Ok();
    //    }
    //}
}