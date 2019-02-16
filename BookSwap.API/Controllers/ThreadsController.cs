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
    public class ThreadsController : ControllerBase
    {
        private readonly BookswapContext _context;

        public ThreadsController(BookswapContext context)
        {
            _context = context;
        }

        // GET: api/Messages
        [HttpGet]
        public IEnumerable<Thread> Get(string user)
        {
            var threads = _context.Thread
                            .Include(t => t.Book)
                            .Include(t => t.Message)
                            .Where(m => m.From.ToLower().Trim() == user.Trim().ToLower() || m.To.ToLower().Trim() == user.Trim().ToLower())
                            .OrderByDescending(m => m.DateAdded)
                            .AsEnumerable()
                            .Select(t => t.SetMessageTitle(user))
                            .ToList();

            return threads;
        }

        [HttpPut]
        public async Task<Thread> Put(ThreadRequest req)
        {
            var book = await _context.Book.FindAsync(req.BookId);
            var now = DateTime.Now;
            var thread = new Thread
            {
                To = book.User,
                From = req.From,
                BookId = req.BookId,
                DateAdded = now,
                IsDeleted = false,
                Message = new List<Message>
                {
                    new Message
                    {
                        Text = "Hello, I am interested in your book.",
                        SentBy = "From",
                        DateAdded = now,
                        IsDeleted = false
                    }
                }
            };

            _context.Thread.Add(thread);
            await _context.SaveChangesAsync();

            return thread;
        }

        public class ThreadRequest
        {
            public string From { get; set; }

            public int BookId { get; set; }
        }
    }
}