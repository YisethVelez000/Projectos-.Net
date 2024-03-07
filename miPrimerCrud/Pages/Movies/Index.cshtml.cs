using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using miPrimerCrud.Data;
using miPrimerCrud.Models;

namespace miPrimerCrud.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly miPrimerCrud.Data.miPrimerCrudContext _context;

        public IndexModel(miPrimerCrud.Data.miPrimerCrudContext context)
        {
            _context = context;
        }

        public IList<Peliculas> Peliculas { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Peliculas != null)
            {
                Peliculas = await _context.Peliculas.ToListAsync();
            }
        }
    }
}
