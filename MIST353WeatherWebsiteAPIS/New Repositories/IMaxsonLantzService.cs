using MIST353WeatherWebsiteAPIS.Data;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public interface IMaxsonLantzService
    {
        Task<int> AddUserAsync(User user);
        Task<int> DeleteUserAsync(int UserID);
    }
}
