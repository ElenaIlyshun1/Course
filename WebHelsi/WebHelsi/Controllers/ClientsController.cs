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
    public class ClientsController : ControllerBase
    {
        private readonly EFDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _env;

        public ClientsController(IHostingEnvironment env,
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
            var model = _context.Clients.Select(
                p => new ClientVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    Surname = p.Surname,
                    DateBirthday = p.DateBirthday,
                    Email = p.User.Email
                    //Password = p.Password
                }).ToList();
            return Ok(model);
        }


        [HttpPost]
        public IActionResult Create([FromBody]ClientAddVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Client m = new Client
            {
                Name = model.Name
            };
            _context.Clients.Add(m);
            _context.SaveChanges();
            return Ok(m.Id);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]ClientDeleteVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var type = _context.Clients.SingleOrDefault(p => p.Id == model.Id);
            if (type != null)
            {
                _context.Clients.Remove(type);
                _context.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody]ClientVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var prod = _context.Clients.SingleOrDefault(p => p.Id == model.Id);
            if (prod != null)
            {
                prod.Name = model.Name;
                _context.SaveChanges();
            }
            return Ok();
        }
    }
}