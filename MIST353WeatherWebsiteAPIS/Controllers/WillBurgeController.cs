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
    public class WillBurgeController : ControllerBase
    {
        private readonly IWillBurgeService WillBurgeService;
        public WillBurgeController(IWillBurgeService WillBurgeService)
        {
            this.WillBurgeService = WillBurgeService;
        }

        [HttpPut("updateuser")]
        public async Task<IActionResult> UpdateUserAsync(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await WillBurgeService.UpdateUserAsync(user);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }

    }
}
