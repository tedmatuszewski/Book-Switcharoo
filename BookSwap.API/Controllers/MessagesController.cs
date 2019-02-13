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

        // GET: api/Messages
        [HttpGet]
        public IEnumerable<Message> GetMessage(string user)
        {
            var messages = _context.Message.Where(m => m.User.ToLower().Trim() == user.Trim().ToLower()).OrderByDescending(m => m.DateAdded).AsEnumerable();

            return messages;
        }

        // GET: api/Messages
        [HttpGet("list")]
        public IEnumerable<MessageList> GetList(string user)
        {
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM [dbo].[MessageList]";
                _context.Database.OpenConnection();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var result = new MessageList
                            {
                                DateAdded = reader.GetDateTime(0),
                                User = reader.GetString(1),
                                Text = reader.GetString(2),
                                From = reader.GetString(3),
                                Title = reader.GetString(4),
                                BookId = reader.GetInt32(5)
                            };

                            yield return result;
                        }
                    }
                }
            }
        }

        // GET: api/Messages/5
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

        // PUT: api/Messages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessage([FromRoute] int id, [FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != message.Id)
            {
                return BadRequest();
            }

            _context.Entry(message).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Messages
        [HttpPost]
        public async Task<IActionResult> PostMessage([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Message.Add(message);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessage", new { id = message.Id }, message);
        }

        // DELETE: api/Messages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage([FromRoute] int id)
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

            _context.Message.Remove(message);

            await _context.SaveChangesAsync();

            return Ok(message);
        }
    }
}