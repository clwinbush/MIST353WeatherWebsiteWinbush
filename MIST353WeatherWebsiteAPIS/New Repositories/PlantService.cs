using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public class PlantService : IPlantService
    {
        private readonly DbContextClass _dbContext;
        public PlantService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<int> AddPlantAsync(Plant plant)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@PlantName", plant.PlantName));
            parameter.Add(new SqlParameter("@ScientificName", plant.ScientificName));
            parameter.Add(new SqlParameter("@Description", plant.Description));
            parameter.Add(new SqlParameter("@ClimateID", plant.Climate));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spCreatePlant @PlantName, @ScientificName, @Description, @ClimateID", parameter.ToArray());

        }
        public async Task<int> DeletePlantAsync(int PlantID)
        {
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spDeletePlant @PlantID");
        }
    }
}
