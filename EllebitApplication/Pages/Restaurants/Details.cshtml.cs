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
    public class DetailsModel : PageModel
    {
        private readonly EllebitApplication.Data.EllebitApplicationContext _context;

        public DetailsModel(EllebitApplication.Data.EllebitApplicationContext context)
        {
            _context = context;
        }

      public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Restaurant == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurant.FirstOrDefaultAsync(m => m.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }
            else 
            {
                Restaurant = restaurant;
            }
            return Page();
        }
    }
}
