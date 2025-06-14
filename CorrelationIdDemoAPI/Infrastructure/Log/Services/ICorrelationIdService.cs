namespace CorrelationIdDemoAPI.Infrastructure.Log.Services
{
    public interface ICorrelationIdService
    {
        string GetCorrelationId();
        void SetCorrelationId(Guid? correlationId = null);
    }
}
