using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
         // app.get()
        [HttpGet]
        //IActionResult
        // Equivalent to Express response handling.
        public IActionResult GetUsers()
        {
            return Ok("users fetched");
        }
    }
}