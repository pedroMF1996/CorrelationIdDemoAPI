using CorrelationIdDemoAPI.Domain.Interfaces.Repositories;
using CorrelationIdDemoAPI.Domain.Interfaces.Services;
using CorrelationIdDemoAPI.Domain.Models;
using CorrelationIdDemoAPI.Infrastructure.Abstract.Services;
using CorrelationIdDemoAPI.Infrastructure.Log.Services;

namespace CorrelationIdDemoAPI.Application.Service
{
    public class WeatherForecastService : AbstractLogService<WeatherForecastService>, IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repository;

        public WeatherForecastService(ICorrelationIdService correlationIdLog, 
            ILogger<WeatherForecastService> logger, 
            IWeatherForecastRepository repository) : base(correlationIdLog, logger)
        {
            _repository = repository;
        }

        public IEnumerable<WeatherForecast> GetAll()
        {
            LogInicio(nameof(GetAll));
            try
            {
                var result = _repository.GetAll();

                LogFim(nameof(GetAll), result);
                return result;
            }
            catch (Exception e)
            {
                LogErro(nameof(GetAll), e);
                throw;
            }
        }
    }
}
