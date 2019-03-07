using BS.Domain;
using BS.Domain.Services;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS.API.Controllers
{
    public class ThreadsController : BsController
    {
        public ThreadsController(IService _service, IDispatcher _dispatcher) : base(_service, _dispatcher)
        {
        }

        [HttpGet]
        public IActionResult Get(string user)
        {
            var response = _service.GetThreads(user);

            return Ok(response.data);
        }

        [HttpPut]
        public IActionResult Put(ThreadRequest req)
        {
            var response = _service.OpenNewThread(req.From, req.BookId);

            return Ok(response.data);
        }

        public class ThreadRequest
        {
            public string From { get; set; }

            public int BookId { get; set; }
        }
    }
}