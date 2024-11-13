using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIST353WeatherWebsite.Data;

namespace MIST353WeatherWebsite.Pages.LandscapingServices
{
    public class DeleteModel : PageModel
    {
        private readonly MIST353WeatherWebsite.Data.LandscapingDbContext _context;

        public DeleteModel(MIST353WeatherWebsite.Data.LandscapingDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LandscapingService LandscapingService { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landscapingservice = await _context.LandscapingServices.FirstOrDefaultAsync(m => m.ServiceId == id);

            if (landscapingservice == null)
            {
                return NotFound();
            }
            else
            {
                LandscapingService = landscapingservice;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landscapingservice = await _context.LandscapingServices.FindAsync(id);
            if (landscapingservice != null)
            {
                LandscapingService = landscapingservice;
                _context.LandscapingServices.Remove(LandscapingService);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
