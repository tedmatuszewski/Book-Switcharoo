using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookSwap.API.Models;

namespace BookSwap.API.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly BookswapContext _context;

        public MessagesController(BookswapContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Message> GetMessages([FromQuery] int threadId)
        {
            var messages = _context.Message.Include(m => m.Thread).Where(m => m.ThreadId == threadId).AsEnumerable().Select(m => m.SetTo());

            return messages;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var message = await _context.Message.FindAsync(id);

            if (message == null)
            {
                return NotFound();
            }

            return Ok(message);
        }

        [HttpPost]
        public async Task<IActionResult> PostMessage([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Message.Add(message);

            await _context.SaveChangesAsync();

            message = await _context.Message.Include(m => m.Thread).SingleOrDefaultAsync(m => m.Id == message.Id);

            return CreatedAtAction("GetMessage", new { id = message.Id }, message.SetTo());
        }
    }
}