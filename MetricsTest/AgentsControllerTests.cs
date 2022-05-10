using MetricsAgent.Controllers;
using MetricsAgent.models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsTest
{
    public class AgentsControllerTests
    {
        private CpuMetricsController _cpuMetricsController;


        public AgentsControllerTests()
        {
            _cpuMetricsController = new CpuMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnOk()
        {
            int agentId = 1;
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            IActionResult result = _cpuMetricsController.GetMetricFromAgent(agentId, fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
