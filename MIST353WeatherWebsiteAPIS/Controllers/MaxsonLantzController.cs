using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace MIST353WeatherWebsiteAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaxsonLantzController : ControllerBase
    {


        private readonly IMaxsonLantzService userService;
        public MaxsonLantzController(IMaxsonLantzService userService)
        {
            this.userService = userService;
        }

        [HttpPost("adduser")]
        public async Task<IActionResult> AddUserAsync(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await userService.AddUserAsync(user);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }

        [HttpDelete("deleteuser")]
        public async Task<IActionResult> DeleteUserAsync(int UserID)
        {

            var response = await userService.DeleteUserAsync(UserID);
            return Ok(response);
        }


    }
}

