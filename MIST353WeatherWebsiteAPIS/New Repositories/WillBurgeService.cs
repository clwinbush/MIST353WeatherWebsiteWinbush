using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public class WillBurgeService : IWillBurgeService
    {
        private readonly DbContextClass _dbContext;
        public WillBurgeService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> UpdateUserAsync(User user)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserId", user.UserId));
            parameter.Add(new SqlParameter("@FirstName", user.FirstName));
            parameter.Add(new SqlParameter("@LastName", user.LastName));
            parameter.Add(new SqlParameter("@Email", user.Email));
            parameter.Add(new SqlParameter("@PhoneNumber", user.PhoneNumber));
            parameter.Add(new SqlParameter("@LocationId", user.LocationId));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spUserUpdate @UserId, @FirstName, @LastName, @Email, @PhoneNumber, @LocationId", parameter.ToArray());
        }

        public async Task

    }
}