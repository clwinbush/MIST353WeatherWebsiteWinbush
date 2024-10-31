using MIST353WeatherWebsiteAPIS.Data;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    //Created interface for database
    public interface IChaseWinbushService
    {
        Task<int> AddPlantAsync(Plant plant);
        Task<int> DeletePlantAsync(int PlantID);
    }
}
