using AssistAPurchase.Models;
using AssistAPurchase.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AssistAPurchase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository Repo { get; }
        public UserController(IUserRepository repo)
        {
            Repo = repo;
        }

        //POST api/User/login
        [HttpPost("login")]
        public IActionResult Login([FromBody], UserModel user)
        {
            var isSuccessful = Repo.Login(user);
            if (isSuccessful)
                return Ok();
            return NotFound();
        }

        //POST api/User/signup
        [HttpPost("signup")]
        public IActionResult SignUp([FromBody], UserModel user)
        {
            var isSuccessful = Repo.SignUp(user);
            if (isSuccessful)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}