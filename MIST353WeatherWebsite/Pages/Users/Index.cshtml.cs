using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIST353WeatherWebsite.Data;

namespace MIST353WeatherWebsite.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly MIST353WeatherWebsite.Data.LandscapingDbContext _context;

        public IndexModel(MIST353WeatherWebsite.Data.LandscapingDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.Users
                .Include(u => u.Location).ToListAsync();
        }
    }
}
