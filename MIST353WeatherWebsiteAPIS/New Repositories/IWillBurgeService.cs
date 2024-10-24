using MIST353WeatherWebsiteAPIS.Data;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public interface IWillBurgeService
    {
        Task<int> UpdateUserAsync(User user);
        Task<IEnumerable<Plant>> GetAllPlantsByLocationAsync(int LocationId);
    }
}