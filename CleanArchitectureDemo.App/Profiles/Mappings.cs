using AutoMapper;

using CleanArchitectureDemo.App.Services;
using CleanArchitectureDemo.App.ViewModels;

namespace CleanArchitectureDemo.App.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            //Vms are coming in from the API, ViewModel are the local entities in Blazor
            CreateMap<WeatherForecastVm, WeatherForecastViewModel>().ReverseMap();
        }
    }
}
