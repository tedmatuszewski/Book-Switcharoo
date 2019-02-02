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
    public class SearchController : ControllerBase
    {
        private readonly BookswapContext _context;

        public SearchController(BookswapContext context)
        {
            _context = context;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SearchRequestModel model)
        {
            var books = await _context.Book.ToAsyncEnumerable().Where(b => b.IsMatch(model.query)).ToList();

            return Ok(books);
        }
    }

    public class SearchRequestModel
    {
        public string query { get; set; }
    }
}