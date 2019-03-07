using BS.Domain;
using BS.Domain.Queries;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    public class SearchController : BsController
    {
        public SearchController(IDispatcher _dispatcher) : base(_dispatcher)
        {
        }

        [HttpPost]
        public IActionResult Post([FromBody] SearchRequestModel model)
        {
            var command = _dispatcher.Process(new SearchBooksQuery(model.query));

            return Ok(command);
        }
    }

    public class SearchRequestModel
    {
        public string query { get; set; }
    }
}