using MIST353WeatherWebsiteAPIS.Data;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public interface IWillBurgeService
    {
        //Implements "Update user" into the interface.
        Task<int> UpdateUserAsync(User user);

        //Implements "Get all plants by location" into the interface.
        Task<IEnumerable<Plant>> GetAllPlantsByLocationAsync(int LocationId);
    }
}