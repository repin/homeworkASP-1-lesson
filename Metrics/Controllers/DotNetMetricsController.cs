using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Metrics.Controllers
{
    [Route("api/metric/dotNet")]
    [ApiController]
    public class DotNetMetricsController : ControllerBase
    {
        [HttpGet("errors-count/agent/{agentID}/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricFromAgent ([FromRoute] int agentId,[FromRoute]TimeSpan fromTime, [FromRoute]TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricAllCluster ([FromRoute]TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }


    }
}
