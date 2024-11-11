using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace MIST353WeatherWebsiteAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaseWinbushController : ControllerBase
    {


        private readonly IChaseWinbushService plantService;
        public ChaseWinbushController(IChaseWinbushService plantService)
        {
            this.plantService = plantService;
        }

        //Added "add plant" to the controller
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

        //Added "delete plant" to the controller
        [HttpDelete("deleteplant")]
        public async Task<IActionResult> DeletePlantAsync(int PlantID)
        {
           
                var response = await plantService.DeletePlantAsync(PlantID);
                return Ok(response);
        }


    }
}

