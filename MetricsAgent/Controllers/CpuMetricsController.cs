using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Metrics.Controllers
{
    [Route("api/metric/cpu")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        [HttpGet("fromTime/{fromTime}/toTime/{toTime}")]
        public IActionResult GetMetricFromAgent([FromRoute]int agentID,[FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
       
    }
}
