using Microsoft.AspNetCore.Mvc;
using School.Domain;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUser(int id)
        {
            return Ok();
        }
    }
}
