using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamenCRUDMVC.Models;

namespace ExamenCRUDMVC.Controllers
{
    public class EditorialesController : Controller
    {
        private readonly ExamenMvcContext _context;

        public EditorialesController(ExamenMvcContext context)
        {
            _context = context;
        }

        // GET: Editoriales
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            // Default sort order
            ViewData["CurrentSort"] = sortOrder;
            IQueryable<Editoriale> editoriales = _context.Editoriales;
            if (!String.IsNullOrEmpty(searchString))
            {
                editoriales = editoriales.Where(u => u.Nombres.Contains(searchString));
            }

            // Apply sorting based on sortOrder parameter
            switch (sortOrder)
            {
                case "NombreAsc":
                    editoriales = editoriales.OrderBy(u => u.Nombres);
                    break;
                case "NombreDesc":
                    editoriales = editoriales.OrderByDescending(u => u.Nombres);
                    break;
            }
            return View(await editoriales.ToListAsync());
        }

        // GET: Editoriales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editoriale = await _context.Editoriales
                .FirstOrDefaultAsync(m => m.Nit == id);
            if (editoriale == null)
            {
                return NotFound();
            }

            return View(editoriale);
        }

        // GET: Editoriales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Editoriales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nit,Nombres,Telefono,Direccion,Email,Sitioweb")] Editoriale editoriale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editoriale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editoriale);
        }

        // GET: Editoriales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editoriale = await _context.Editoriales.FindAsync(id);
            if (editoriale == null)
            {
                return NotFound();
            }
            return View(editoriale);
        }

        // POST: Editoriales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nit,Nombres,Telefono,Direccion,Email,Sitioweb")] Editoriale editoriale)
        {
            if (id != editoriale.Nit)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editoriale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditorialeExists(editoriale.Nit))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(editoriale);
        }

        // GET: Editoriales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editoriale = await _context.Editoriales
                .FirstOrDefaultAsync(m => m.Nit == id);
            if (editoriale == null)
            {
                return NotFound();
            }

            return View(editoriale);
        }

        // POST: Editoriales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var editoriale = await _context.Editoriales.FindAsync(id);
            if (editoriale != null)
            {
                _context.Editoriales.Remove(editoriale);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditorialeExists(int id)
        {
            return _context.Editoriales.Any(e => e.Nit == id);
        }
    }
}
