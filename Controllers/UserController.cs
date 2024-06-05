using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using IffahService.Models;

namespace IffahService.Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Mengambil semua data dari tabel Users
            var users = _context.Users.ToList();

            // Mengembalikan data pengguna dalam format JSON
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("This is POST for User");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("This is PUT for User");
        }

        [HttpPatch]
        public IActionResult Patch()
        {
            return Ok("This is PATCH for User");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("This is DELETE for User");
        }
    }
}
