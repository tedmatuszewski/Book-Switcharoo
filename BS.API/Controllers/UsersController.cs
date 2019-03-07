using BS.Domain;
using BS.Domain.Commands;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    public class UsersController : BsController
    {
        public UsersController(IDispatcher _dispatcher) : base(_dispatcher)
        {
        }

        [HttpPost("Register")]
        public IActionResult PostRegister([FromBody] UserDTO dto)
        {
            var command = _dispatcher.Process(new RegisterUserCommand(dto));

            return Ok(command);
        }

        [HttpPost("Login")]
        public IActionResult PostLogin([FromBody] LoginDTO dto)
        {
            var command = _dispatcher.Process(new SignInCommand(dto));

            return Ok(command);
        }
    }
}