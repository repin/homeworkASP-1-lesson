using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/metric/cpu")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        [HttpGet("agent/{agentID}/fromTime/{fromTime}/toTime/{toTime}")]
        public IActionResult GetMetricFromAgent([FromRoute]int agentID,[FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
       
        [HttpGet("cluster/fromTime/{fromTime}/toTime/{toTime}")]
        public IActionResult GetMetricFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
