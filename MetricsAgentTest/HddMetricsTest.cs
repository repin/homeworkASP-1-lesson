using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTest
{
    public class HddMetricsTest
    {

        private HddMetricsController _hddMetricsController;

        public HddMetricsTest()
        {
            _hddMetricsController = new HddMetricsController();
        }
        [Fact]
        public void GetMetricFromAgent_ResultOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(1);
            TimeSpan toTime = TimeSpan.FromSeconds(2);
            IActionResult result = _hddMetricsController.GetMetricFromAgent(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
