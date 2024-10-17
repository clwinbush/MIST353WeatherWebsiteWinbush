using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MIST353WeatherWebsiteAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {


        private readonly IPlantService plantService;
        public PlantController(IPlantService plantService)
        {
            this.plantService = plantService;
        }

        [HttpPost("addplant")]
        public async Task<IActionResult> AddPlantAsync(Plant plant)
        {
            if (plant == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await plantService.AddPlantAsync(plant);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }

        [HttpDelete("deleteplant")]
        public async Task<int> DeletePlantAsync(int PlantID)
        {
            try
            {
                var response = await plantService.DeletePlantAsync(PlantID);
                return response;
            }
            catch
            {
                throw;
            }

        }


    }
}

