using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIST353WeatherWebsite.Data;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace MIST353WeatherWebsite.Pages.LocationCRUD
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public IndexModel(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }

        public IList<Location> Location { get;set; } = default!;

        public async Task<IActionResult> OnGetAsync(String LocationId)
        {
            if(string.IsNullOrEmpty(LocationId))
            {
                return Page();
            }

            try
            {
                //Make the endpoint
                string requestUrl = $"https://localhost:7299/api/WillBurge/getallplantsbylocation?LocationId={Uri.EscapeDataString(LocationId)}";

                //Send request to API
                Location = await _httpClient.GetFromJsonAsync<IList<Location>>(requestUrl) ?? new List<Location>();
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            return Page();
        }
    }
}
