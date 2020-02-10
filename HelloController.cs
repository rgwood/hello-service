using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hello_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(string name)
        {
            _logger.LogInformation($"Called with name '{name}'");
            return $"Hello {name}!";
        }
    }
}
