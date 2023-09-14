using CleanArchitectureDemo.Application.Features.Weather.Queires.GetWeatherForecast;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("forecast", Name = "GetWeatherForecast")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<WeatherForecastVm>>> GetWeatherForecast()
        {
            var dtos = await _mediator.Send(new GetWeatherForecastQuery());
            return Ok(dtos);
        }
    }
}
