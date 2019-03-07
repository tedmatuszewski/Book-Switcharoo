using BS.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BsController : ControllerBase
    {
        protected IDispatcher _dispatcher;

        public BsController(IDispatcher dispatcher)
        {
            this._dispatcher = dispatcher;
        }
    }
}
