using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EllebitApplication.Data;
using EllebitApplication.Models;

namespace EllebitApplication.Pages.Restaurants
{
    public class IndexModel : PageModel
    {
        private readonly EllebitApplication.Data.EllebitApplicationContext _context;

        public IndexModel(EllebitApplication.Data.EllebitApplicationContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Restaurant != null)
            {
                Restaurant = await _context.Restaurant.ToListAsync();
            }
        }
    }
}
