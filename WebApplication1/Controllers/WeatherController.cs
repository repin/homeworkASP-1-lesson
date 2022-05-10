using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Linq;
using System;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherHolder _weatherHolder;
        public WeatherController(WeatherHolder holder)
        {
            _weatherHolder = holder;
        }

        [HttpGet("read")]
        public IActionResult Read([FromQuery]DateTime timeStart, [FromQuery]DateTime timeEnd)
        {
            return Ok(_weatherHolder.TakeTempToSpan(timeStart,timeEnd));
        }

        [HttpPost("create")]
        public IActionResult Create([FromQuery]DateTime time, [FromQuery]float temp)
        {
            _weatherHolder.Add(time, temp);
            return Ok();
        }

        [HttpPut("edit")]
        public IActionResult  Edit([FromQuery]DateTime time,[FromQuery]float temp)
        {
            _weatherHolder.Edit(time, temp);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery]DateTime time)
        {
            _weatherHolder.Delete(time);
            return Ok();
        }

    }

}
