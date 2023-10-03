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
    public class IndexModel : PageModel
    {
        private readonly RePlash.Data.RePlashContext _context;

        public IndexModel(RePlash.Data.RePlashContext context)
        {
            _context = context;
        }

        public IList<Photo> Photo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Photo != null)
            {
                Photo = await _context.Photo.ToListAsync();
            }
        }
    }
}
