using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public class ChristianMarchittoService : IChristianMarchittoService
    {
        private readonly DbContextClass _dbContext;
        public ChristianMarchittoService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Plant>> PlantsInTemp(int avgTemp)
        {
            var param = new SqlParameter("@AverageTemperature", avgTemp);
            var plantTempDetails = await Task.Run(() => _dbContext.P.FromSqlRaw(@"exec spPlantsInTemp @AverageTemperature", param).ToListAsync());
            return plantTempDetails;
        }

        public async Task<IEnumerable<LandscapingService>> ServiceByClimate(int climateId)
        {
            var param = new SqlParameter("@ClimateID", climateId);
            var serviceDetails = await Task.Run(() => _dbContext.LS.FromSqlRaw(@"exec spServiceByClimate @ClimateID", param).ToListAsync());
            return serviceDetails;

        }
    }
}
