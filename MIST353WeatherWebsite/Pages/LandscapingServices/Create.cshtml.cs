using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MIST353WeatherWebsite.Data;

namespace MIST353WeatherWebsite.Pages.LandscapingServices
{
    public class CreateModel : PageModel
    {
        private readonly MIST353WeatherWebsite.Data.LandscapingDbContext _context;

        public CreateModel(MIST353WeatherWebsite.Data.LandscapingDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LandscapingService LandscapingService { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LandscapingServices.Add(LandscapingService);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
