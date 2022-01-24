using Localiza.Frotas.Infra.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.Frotas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SingletonController : Controller
    {
        private readonly SingletonContainer singletonContainer;
        public SingletonController(SingletonContainer singletonContainer)
        {
            this.singletonContainer = singletonContainer;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            //var singleton = singletonContainer;

            return Ok(singletonContainer);
        }
    }
}
