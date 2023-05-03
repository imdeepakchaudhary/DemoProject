
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DataAccess.UnitOfWork;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }
    [Authorize]
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task< IEnumerable<WeatherForecast>> Get()
    {
        var abc = await _unitOfWork.AspNetUsersRepository.Search(1, 10);

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
