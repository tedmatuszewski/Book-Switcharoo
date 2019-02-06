using BookSwap.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSwap.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookswapContext _context;

        public BooksController(BookswapContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBook(string owner = null)
        {
            var books = _context.Book.Where(b => b.IsDeleted == false);

            if(owner != null)
            {
                books = books.Where(b => b.User.ToLower().Trim() == owner.ToLower().Trim());
            }

            return Ok(books);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var book = await _context.Book.Where(b => b.IsDeleted == false).SingleOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook([FromRoute] int id, [FromBody] Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> PostBook([FromBody] Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Book.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var book = await _context.Book.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            book.IsDeleted = true;

            await _context.SaveChangesAsync();

            return Ok(book);
        }
    }
}