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
       

        private readonly IPlantService productService;
        public PlantController(IPlantService productService)
        {
            this.productService = productService;
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
                var response = await PlantService.AddPlantAsync(plant);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
    }
}
