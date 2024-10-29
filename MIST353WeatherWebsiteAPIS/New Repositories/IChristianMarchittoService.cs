using MIST353WeatherWebsiteAPIS.Data;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public interface IChristianMarchittoService
    {
        Task<IEnumerable<Plant>> PlantsInTemp(int avgTemp);
        Task<IEnumerable<LandscapingService>> ServiceByClimate(int climateId);
    }
}
