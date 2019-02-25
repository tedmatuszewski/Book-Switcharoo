using BS.Domain.Services;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS.API.Controllers
{
    public class MessagesController : BsController
    {
        public MessagesController(IService _service) : base(_service)
        {
        }

        [HttpGet]
        public IActionResult GetMessages([FromQuery] int threadId)
        {
            var response = _service.GetMessages(threadId);

            return Ok(response.data);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetMessage([FromRoute] int id)
        {
            var response = _service.GetMessage(id);

            return Ok(response.data);
        }

        [HttpPost]
        public IActionResult PostMessage([FromBody] MessageDTO message)
        {
            var response = _service.CreateMessage(message);

            return CreatedAtAction("GetMessage", new { id = response.data.Id }, response.data);
        }
    }
}