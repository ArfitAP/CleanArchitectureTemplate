using CleanArchitectureDemo.App.ViewModels;

namespace CleanArchitectureDemo.App.Contracts
{
    public interface IWeatherService
    {
        Task<WeatherForecastViewModel[]> GetAllWeatherForecast();
    }
}
