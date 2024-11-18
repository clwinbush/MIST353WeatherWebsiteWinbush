using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using MIST353WeatherWebsite.Data;
using Microsoft.DotNet.MSIdentity.Shared;

namespace MIST353WeatherWebsite.Pages
{
    public class PlantsInTempModel : PageModel
    {
        [BindProperty]
        public double Temperature { get; set; }

        public List<Plant> Plants { get; set; } = new List<Plant>();
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string requestUrl = $"https://localhost:7299/api/ChristianMarchitto/plantsintemperature?avgTemp={Temperature}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(requestUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Plants = JsonSerializer.Deserialize<List<Plant>>(jsonResponse);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return Page();
        }
    }
}
