using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/metric/dotNet")]
    [ApiController]
    public class DotNetMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricFromAgent ([FromRoute]TimeSpan fromTime, [FromRoute]TimeSpan toTime)
        {
            return Ok();
        }

    }
}
