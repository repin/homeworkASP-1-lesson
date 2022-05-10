using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTest
{
    public class CpuMetricsTest
    {

        private CpuMetricsController _cpuMetricsController;

        public CpuMetricsTest()
        {
            _cpuMetricsController = new CpuMetricsController();
        }
        [Fact]
        public void GetMetricFromAgent_ResultOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(1);
            TimeSpan toTime = TimeSpan.FromSeconds(2);
            IActionResult result =  _cpuMetricsController.GetMetricFromAgent(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
