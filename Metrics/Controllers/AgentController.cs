using Metrics.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Metrics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private AgentPool _agentPool;

        public AgentController(AgentPool agentPool)
        {
            _agentPool = agentPool;
        }

        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            _agentPool.Add(agentInfo);
            return Ok();
        }

        [HttpPut ("enable/{agentID}")]
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpPut ("disable/{agentID}")]
        public IActionResult DisableAgentByID([FromRoute] int agentId)
        {
            return Ok();
        }
        
        [HttpGet("get")]
        public IActionResult GetAgents()
        {
            return Ok(_agentPool.Get()) ;
        }
    }
}
