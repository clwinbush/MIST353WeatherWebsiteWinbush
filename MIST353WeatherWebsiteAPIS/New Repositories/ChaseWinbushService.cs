using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public class ChaseWinbushService : IChaseWinbushService
    {
        private readonly DbContextClass _dbContext;
        public ChaseWinbushService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        // this is a method to add plants from the database.
        public async Task<int> AddPlantAsync(Plant plant)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@PlantName", plant.PlantName));
            parameter.Add(new SqlParameter("@ScientificName", plant.ScientificName));
            parameter.Add(new SqlParameter("@Description", plant.Description));
            parameter.Add(new SqlParameter("@ClimateID", plant.ClimateId));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spCreatePlant @PlantName, @ScientificName, @Description, @ClimateID", parameter.ToArray());

        }
        // this is a method to delete plants from the database.
        public async Task<int> DeletePlantAsync(int PlantID)
        {

            var param = new SqlParameter("@PlantID", PlantID);
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spDeletePlant @PlantID", param);
        }
    }
}
