using AutoMapper;
using CleanArchitectureDemo.Application.Contracts.Persistence;
using CleanArchitectureDemo.Domain.Entities;
using MediatR;

namespace CleanArchitectureDemo.Application.Features.Weather.Queires.GetWeatherForecast
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, List<WeatherForecastVm>>
    {
        private readonly IWeatherRepository _weatherRepository;
        private readonly IMapper _mapper;

        public GetWeatherForecastQueryHandler(IMapper mapper, IWeatherRepository weatherRepository)
        {
            _mapper = mapper;
            _weatherRepository = weatherRepository;
        }

        public async Task<List<WeatherForecastVm>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
        {
            var allCategories = await _weatherRepository.GetAllForecasts();
            //throw new Exception("custom msg");
            return _mapper.Map<List<WeatherForecastVm>>(allCategories);
        }
    }
}
