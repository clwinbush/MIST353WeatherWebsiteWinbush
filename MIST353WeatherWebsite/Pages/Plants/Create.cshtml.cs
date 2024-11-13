using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MIST353WeatherWebsite.Data;

namespace MIST353WeatherWebsite.Pages.Plants
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
        ViewData["ClimateId"] = new SelectList(_context.Climates, "ClimateId", "ClimateId");
            return Page();
        }

        [BindProperty]
        public Plant Plant { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Plants.Add(Plant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
