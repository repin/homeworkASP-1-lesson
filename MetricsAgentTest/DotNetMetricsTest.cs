using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTest
{
    public class DotNetMetricsTest
    {

        private DotNetMetricsController _dotNetMetricsController;

        public DotNetMetricsTest()
        {
            _dotNetMetricsController = new DotNetMetricsController();
        }
        [Fact]
        public void GetMetricFromAgent_ResultOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(1);
            TimeSpan toTime = TimeSpan.FromSeconds(2);
            IActionResult result = _dotNetMetricsController.GetMetricFromAgent(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
