using MIST353WeatherWebsiteAPIS.Data;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public interface IChaseWinbushService
    {
        Task<int> AddPlantAsync(Plant plant);
        Task<int> DeletePlantAsync(int PlantID);
    }
}
