using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookSwap.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookSwap.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookswapContext context;

        public BooksController(BookswapContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            var books = context.Book.ToList();
            
            return books;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}