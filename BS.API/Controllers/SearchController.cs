using BS.Domain;
using BS.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BS.API.Controllers
{
    public class SearchController : BsController
    {
        public SearchController(IService _service, IDispatcher _dispatcher) : base(_service, _dispatcher)
        {
        }

        [HttpPost]
        public IActionResult Post([FromBody] SearchRequestModel model)
        {
            var response = _service.SearchBooks(model.query);

            return Ok(response.data);
        }
    }

    public class SearchRequestModel
    {
        public string query { get; set; }
    }
}