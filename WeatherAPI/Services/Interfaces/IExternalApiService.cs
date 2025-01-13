namespace WeatherAPI.Services.Interfaces
{
    public interface IExternalApiService
    {
        Task<bool> CallEzternalApi();
    }
}
