using CorrelationIdDemoAPI.Domain.Models;

namespace CorrelationIdDemoAPI.Domain.Interfaces.Services
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetAll();
    }
}
