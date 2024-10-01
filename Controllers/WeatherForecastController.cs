using Microsoft.AspNetCore.Mvc;

namespace MicroserviceTwo.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorchingdscsdfsf"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public ActionResult<IList<WeatherForecast>> Get()
    {
        IList<WeatherForecast> weatherForecast= new List<WeatherForecast>();
        for (int i = 0; i < 10; i++)
        {
            WeatherForecast weather = new WeatherForecast();
            weather.ProductName= "Product-" + i;
            weather.ProductDescription= "Product Description-" + i;
            weather.Date= DateTime.Now;
            weather.Cost= i;
            weather.Count= i+ 1;
            weatherForecast.Add(weather);
        }
        return Ok(weatherForecast);
    }

}
