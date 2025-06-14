using CorrelationIdDemoAPI.Domain.Models;

namespace CorrelationIdDemoAPI.Domain.Interfaces.Repositories
{
    public interface IWeatherForecastRepository
    {
        public IEnumerable<WeatherForecast> GetAll();
    }
}
