using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.Contracts.Persistence
{
    public interface IWeatherRepository : IAsyncRepository<WeatherForecast>
    {
        Task<List<WeatherForecast>> GetAllForecasts();
    }
}
