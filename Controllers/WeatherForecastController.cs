using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecast> forecasts = new List<WeatherForecast>()
        {
            new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 30,
                Summary = "Sunny"
            }
        };

        // GET
        [HttpGet]
        public ActionResult<List<WeatherForecast>> Get()
        {
            return forecasts;
        }

        // POST
        [HttpPost]
        public IActionResult Post([FromBody] WeatherForecast forecast)
        {
            forecasts.Add(forecast);
            return Ok(forecast);
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WeatherForecast forecast)
        {
            if (id < 0 || id >= forecasts.Count)
                return NotFound();

            forecasts[id] = forecast;

            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= forecasts.Count)
                return NotFound();

            forecasts.RemoveAt(id);

            return NoContent();
        }
    }
}