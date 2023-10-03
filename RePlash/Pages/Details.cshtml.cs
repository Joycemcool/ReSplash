using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RePlash.Data;
using RePlash.Models;

namespace RePlash.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly RePlash.Data.RePlashContext _context;

        public DetailsModel(RePlash.Data.RePlashContext context)
        {
            _context = context;
        }

      public Photo Photo { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Photo == null)
            {
                return NotFound();
            }

            var photo = await _context.Photo.FirstOrDefaultAsync(m => m.PhotoId == id);
            if (photo == null)
            {
                return NotFound();
            }
            else 
            {
                Photo = photo;
            }
            return Page();
        }
    }
}
