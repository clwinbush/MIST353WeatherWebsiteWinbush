using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MIST353WeatherWebsiteAPIS.New_Repositories
{
    public class UserService : IUserService
    {
        private readonly DbContextClass _dbContextClass;
        public UserService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

    }
}