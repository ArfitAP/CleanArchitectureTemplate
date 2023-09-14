using MediatR;

namespace CleanArchitectureDemo.Application.Features.Weather.Queires.GetWeatherForecast
{
    public class GetWeatherForecastQuery : IRequest<List<WeatherForecastVm>>
    {

    }
}
