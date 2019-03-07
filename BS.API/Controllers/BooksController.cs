using BS.Domain;
using BS.Domain.Services;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;
using BS.Domain.Queries;
using BS.Domain.Commands;

namespace BS.API.Controllers
{
    public class BooksController : BsController
    {
        public BooksController(IService _service, IDispatcher _dispatcher) : base(_service, _dispatcher)
        {
        }

        [HttpGet]
        public IActionResult GetBook(string user = null)
        {
            var query = _dispatcher.Process(new GetBooksByEmailQuery(user));
            
            return Ok(query.Result);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetBook([FromRoute] int id)
        {
            var response = _service.GetBook(id);

            return Ok(response.data);
        }

        [HttpPut("{id}")]
        public IActionResult PutBook([FromRoute] int id, [FromBody] BookDTO book)
        {
            var response = _service.UpdateBook(id, book);

            return Ok(response.data);
        }

        [HttpPost]
        public IActionResult PostBook([FromBody] BookDTO book)
        {
            var command = _dispatcher.Process(new CreateBookCommand(book));

            //command.Result

            return CreatedAtAction("GetBook", new { id = response.data.Id }, response.data);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            var response = _service.DeleteBook(id);

            return Ok(response.data);
        }
    }
}