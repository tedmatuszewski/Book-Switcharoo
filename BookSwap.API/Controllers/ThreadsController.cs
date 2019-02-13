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
                            .AsEnumerable();

            return threads;
        }
    }
}