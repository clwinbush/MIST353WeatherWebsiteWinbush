using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIST353WeatherWebsite.Data;
using System.Net.Http;

namespace MIST353WeatherWebsite.Pages.LandscapingServices
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IList<LandscapingService> LandscapingService { get;set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return Page();
            }
            try
            {
                //Make the endpoint
                string requestUrl = $"https://localhost:7299/api/ChristianMarchitto/getservicebyclimate?climateId={Uri.EscapeDataString(id)}";
                //Send get request to API
                LandscapingService = await _httpClient.GetFromJsonAsync<IList<LandscapingService>>(requestUrl) ?? new List<LandscapingService>();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            return Page();
        }
    }
}
