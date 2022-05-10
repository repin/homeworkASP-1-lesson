using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTest
{
    public class NetworkMetricsTest
    {

        private NetworkMetricsController _networkMetricsController;

        public NetworkMetricsTest()
        {
            _networkMetricsController = new NetworkMetricsController();
        }
        [Fact]
        public void GetMetricFromAgent_ResultOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(1);
            TimeSpan toTime = TimeSpan.FromSeconds(2);
            IActionResult result = _networkMetricsController.GetMetricFromAgent(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
