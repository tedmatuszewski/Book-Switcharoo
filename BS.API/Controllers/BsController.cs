using BS.Domain;
using BS.Domain.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.IO;
using System.Threading.Tasks;

namespace BS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BsController : ControllerBase
    {
        protected IService _service;

        protected IDispatcher _dispatcher;

        public BsController(IService service, IDispatcher dispatcher)
        {
            this._service = service;
            this._dispatcher = dispatcher;
        }
    }
}
