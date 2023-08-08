using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly WeatherForecastService _service;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _service = new WeatherForecastService();
        }

        [HttpGet]
       
       public IEnumerable<WeatherForecast> Get() 
       {
            var result = _service.Get();
            return result;
       }
       
       
       
       
       
       
       
       
    }
}