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
    [Route("v1/[controller]")]
    [ApiController]
    public class ThreadsController : BsController
    {
        public ThreadsController(IService _service) : base(_service)
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