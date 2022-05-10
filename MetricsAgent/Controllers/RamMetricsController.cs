using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/ram/available")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricFromAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
///e. api/metrics/ram/available/from/{fromTime}/to/{toTime}.
