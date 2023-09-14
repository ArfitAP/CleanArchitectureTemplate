using AutoMapper;
using CleanArchitectureDemo.App.Contracts;
using CleanArchitectureDemo.App.Services.Base;
using CleanArchitectureDemo.App.ViewModels;

namespace CleanArchitectureDemo.App.Services
{
    public class WeatherService : BaseDataService, IWeatherService
    {
        private readonly IMapper _mapper;

        public WeatherService(IClient client, IMapper mapper) : base(client)
        {
            _mapper = mapper;
        }

        public async Task<WeatherForecastViewModel[]> GetAllWeatherForecast()
        {
            var allForecasts = await _client.GetWeatherForecastAsync();
            var mappedForecasts = _mapper.Map<ICollection<WeatherForecastViewModel>>(allForecasts);
            return mappedForecasts.ToArray();

        }
    }
}