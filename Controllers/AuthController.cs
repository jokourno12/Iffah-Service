using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("/auth")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is GET");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("This is POST");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("This is PUT");
        }

        [HttpPatch]
        public IActionResult Patch()
        {
            return Ok("This is PATCH");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("This is DELETE");
        }
    }
}
