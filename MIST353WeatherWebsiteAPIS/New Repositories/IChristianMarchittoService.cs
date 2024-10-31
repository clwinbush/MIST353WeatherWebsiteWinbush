using MIST353WeatherWebsiteAPIS.Data;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public interface IChristianMarchittoService
    {
        //Creates the interface for the PlantsInTemp sp
        Task<IEnumerable<Plant>> PlantsInTemp(int avgTemp);
        //Creates the interface for the ServiceByClimate sp
        Task<IEnumerable<LandscapingService>> ServiceByClimate(int climateId);
    }
}
