using MIST353WeatherWebsiteAPIS.Data;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public interface IPlantService
    {
        Task<int> AddPlantAsync(Plant plant);
    }
}
