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
        public double Temperature { get; set; } //Value that the user enters that goes into the query

        public List<Plant> Plants { get; set; } = new List<Plant>(); //List of the plants that are in the temperature range
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) //Returns the page if the entry is not valid
            {
                return Page();
            }
            string requestUrl = $"https://localhost:7299/api/ChristianMarchitto/plantsintemperature?avgTemp={Temperature}"; //API link that adds the user input into it

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(requestUrl); //Sends the GET request to the API
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync(); //Puts the resonponse into a string
                    Plants = JsonSerializer.Deserialize<List<Plant>>(jsonResponse); //Turns the JSON from the API into a Plant class that goes into the list
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
