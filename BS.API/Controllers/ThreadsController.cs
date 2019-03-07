using BS.Domain;
using BS.Domain.Queries;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    public class ThreadsController : BsController
    {
        public ThreadsController(IDispatcher _dispatcher) : base(_dispatcher)
        {
        }

        [HttpGet]
        public IActionResult Get(string user)
        {
            var query = _dispatcher.Process(new GetThreadsByEmailQuery(user));

            return Ok(query);
        }

        [HttpPut]
        public IActionResult Put(ThreadRequest req)
        {
            var command = _dispatcher.Process(new Domain.Commands.CreateThreadCommand(req.From, req.BookId));

            return Ok(command);
        }

        public class ThreadRequest
        {
            public string From { get; set; }

            public int BookId { get; set; }
        }
    }
}