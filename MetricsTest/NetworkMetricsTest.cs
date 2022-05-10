using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetricsTest
{
    public class NetworkMetricsTest
    {
        private NetworkMetricsController _networkMetricsController;

        public NetworkMetricsTest()
        {
            _networkMetricsController = new NetworkMetricsController();
        }

        [Fact]
        public void GetMetricFromAgent_ReturnOk()
        {
            int idAgent = 1;
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            IActionResult result = _networkMetricsController.GetMetricFromAgent(idAgent, fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
        [Fact]
        public void GetMetricFromCluster_ReturnOk()
        {
            TimeSpan fromTime=TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            IActionResult result = _networkMetricsController.GetMetricAllCluster(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult> (result);
        }
    }
}
