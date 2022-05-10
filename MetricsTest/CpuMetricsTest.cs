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
    public class DotNetMetricsTest
    {
        private DotNetMetricsController _dotNetMetricsController;

        public DotNetMetricsTest()
        {
            _dotNetMetricsController = new DotNetMetricsController();
        }

        [Fact]
        public void GetMetricFromAgent_ReturnOk()
        {
            int idAgent = 1;
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            IActionResult result = _dotNetMetricsController.GetMetricFromAgent(idAgent, fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
        [Fact]
        public void GetMetricFromCluster_ReturnOk()
        {
            TimeSpan fromTime=TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            IActionResult result = _dotNetMetricsController.GetMetricAllCluster(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult> (result);
        }
    }
}
