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
    public class DeleteModel : PageModel
    {
        private readonly miPrimerCrud.Data.miPrimerCrudContext _context;

        public DeleteModel(miPrimerCrud.Data.miPrimerCrudContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Peliculas Peliculas { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Peliculas == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas.FirstOrDefaultAsync(m => m.Id == id);

            if (peliculas == null)
            {
                return NotFound();
            }
            else 
            {
                Peliculas = peliculas;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Peliculas == null)
            {
                return NotFound();
            }
            var peliculas = await _context.Peliculas.FindAsync(id);

            if (peliculas != null)
            {
                Peliculas = peliculas;
                _context.Peliculas.Remove(Peliculas);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
