using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        // GET /healthcheck
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Api is working correctly");
        }
    }
}
