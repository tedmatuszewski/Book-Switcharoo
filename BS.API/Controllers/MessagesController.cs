using BS.Domain;
using BS.Domain.Commands;
using BS.Domain.Queries;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    public class MessagesController : BsController
    {
        public MessagesController(IDispatcher _dispatcher) : base(_dispatcher)
        {
        }

        [HttpGet]
        public IActionResult GetMessages([FromQuery] int threadId)
        {
            var query = _dispatcher.Process(new GetMessageByThreadIdQuery(threadId));
            
            return Ok(query);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetMessage([FromRoute] int id)
        {
            var query = _dispatcher.Process(new GetMessageByIdQuery(id));

            return Ok(query);
        }

        [HttpPost]
        public IActionResult PostMessage([FromBody] MessageDTO message)
        {
            var query = _dispatcher.Process(new CreateMessageCommand(message));

            return CreatedAtAction("GetMessage", new { id = query.Result.Id }, query);
        }
    }
}