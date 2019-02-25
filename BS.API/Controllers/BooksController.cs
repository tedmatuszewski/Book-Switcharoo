using BS.Domain.Services;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    public class BooksController : BsController
    {
        public BooksController(IService _service) : base(_service)
        {
        }

        [HttpGet]
        public IActionResult GetBook(string user = null)
        {
            var response = _service.GetBook(user);
            
            return Ok(response.data);
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
            var response = _service.CreateBook(book);

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