using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Zexpo.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ActionName("GetMethod")]
        public string Getmethod()
        {
           _logger.LogInformation("Site hit today at {DT}", DateTime.UtcNow.ToString());
            return "GET";
        }
        [HttpPost]
        [ActionName("PostMethod")]
        public string Postmethod(string name) { return "Hello " + name;}
    }
}
