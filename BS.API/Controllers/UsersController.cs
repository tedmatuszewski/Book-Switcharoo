using BS.Domain.Services;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    public class UsersController : BsController
    {
        public UsersController(IService _service) : base(_service)
        {
        }

        [HttpPost("Register")]
        public IActionResult PostRegister([FromBody] UserDTO dto)
        {
            var response = _service.RegisterUser(dto);

            return Ok(response.data);
        }
    }
}