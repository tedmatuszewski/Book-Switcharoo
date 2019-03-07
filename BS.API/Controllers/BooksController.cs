using BS.Domain;
using BS.Domain.Commands;
using BS.Domain.Queries;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    public class BooksController : BsController
    {
        public BooksController(IDispatcher _dispatcher) : base(_dispatcher)
        {
        }

        [HttpGet]
        public IActionResult GetBook(string user = null)
        {
            var query = _dispatcher.Process(new GetBooksByEmailQuery(user));
            
            return Ok(query);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetBook([FromRoute] int id)
        {
            var query = _dispatcher.Process(new GetBookByIdQuery(id));

            return Ok(query);
        }

        [HttpPut("{id}")]
        public IActionResult PutBook([FromRoute] int id, [FromBody] BookDTO book)
        {
            var query = _dispatcher.Process(new CreateBookCommand(book));

            return Ok(query);
        }

        [HttpPost]
        public IActionResult PostBook([FromBody] BookDTO book)
        {
            var command = _dispatcher.Process(new CreateBookCommand(book));
            
            return CreatedAtAction("GetBook", new { id = command.Result.Id }, command);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            var command = _dispatcher.Process(new DeleteBookCommand(id));

            return Ok(command);
        }
    }
}