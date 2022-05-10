using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTest
{
    public class RamMetricsTest
    {

        private RamMetricsController _ramMetricsController;

        public RamMetricsTest()
        {
            _ramMetricsController = new RamMetricsController();
        }
        [Fact]
        public void GetMetricFromAgent_ResultOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(1);
            TimeSpan toTime = TimeSpan.FromSeconds(2);
            IActionResult result = _ramMetricsController.GetMetricFromAgent(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
