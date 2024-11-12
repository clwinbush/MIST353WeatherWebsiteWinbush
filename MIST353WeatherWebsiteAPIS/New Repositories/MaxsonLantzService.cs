using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public class MaxsonLantzService : IMaxsonLantzService
    {
        private readonly DbContextClass _dbContext;
        public MaxsonLantzService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<int> AddUserAsync(User user)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@FirstName", user.FirstName));
            parameter.Add(new SqlParameter("@LastName", user.LastName));
            parameter.Add(new SqlParameter("@Email", user.Email));
            parameter.Add(new SqlParameter("@PhoneNumber", user.PhoneNumber));
            parameter.Add(new SqlParameter("@LocationID", user.LocationId));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spCreateUser @FirstName, @LastName, @Email, @PhoneNumber, @LocationID", parameter.ToArray());

        }
        public async Task<int> DeleteUserAsync(int UserID)
        {

            var param = new SqlParameter("@UserID", UserID);
            return await _dbContext.Database.ExecuteSqlRawAsync("exec spDeleteUser @UserID", param);
        }
    }
}
