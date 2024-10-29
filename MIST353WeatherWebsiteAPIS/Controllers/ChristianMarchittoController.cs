using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MIST353WeatherWebsiteAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChristianMarchittoController : ControllerBase
    {
        private readonly IChristianMarchittoService ChristianMarchittoService;
        public ChristianMarchittoController(IChristianMarchittoService ChristianMarchittoService)
        {
            this.ChristianMarchittoService = ChristianMarchittoService;
        }
        [HttpGet("plantsintemperature")]
        public async Task<IEnumerable<Plant>> PlantsInTemp(int avgTemp)
        {
            try
            {
                var response = await ChristianMarchittoService.PlantsInTemp(avgTemp);
                if (response == null)
                {
                    return null;
                }
                return response;
            }
            catch
            {
                throw;
            }
        }
        [HttpGet("getservicebyclimate")]
        public async Task<IEnumerable<LandscapingService>> ServiceByClimate(int climateId)
        {
            try
            {
                var response = await ChristianMarchittoService.ServiceByClimate(climateId);
                if (response == null)
                {
                    return null;
                }
                return response;
            }
            catch
            {
                throw;
            }
        }

    }
}
