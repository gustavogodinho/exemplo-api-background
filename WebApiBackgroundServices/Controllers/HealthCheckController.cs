using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApiBackgroundServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok($"{DateTime.UtcNow}");
        }

    }
}
