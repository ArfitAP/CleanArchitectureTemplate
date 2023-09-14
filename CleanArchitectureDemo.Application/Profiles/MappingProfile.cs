using AutoMapper;
using CleanArchitectureDemo.Application.Features.Weather.Queires.GetWeatherForecast;
using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastVm>().ReverseMap();
        }
    }
}
