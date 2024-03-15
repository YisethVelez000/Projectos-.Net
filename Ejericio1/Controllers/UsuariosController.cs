using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ejericio1.Models;

namespace Ejericio1.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Ejercicio1Context _context;

        public UsuariosController(Ejercicio1Context context)
        {
            _context = context;
        }

        // GET: Usuarios
        // GET: Usuarios (with optional sorting and search parameters)
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            // Default sort order
            ViewData["CurrentSort"] = sortOrder;

            // Retrieve users from database
            IQueryable<Usuario> usuarios = _context.Usuarios
                .Include(u => u.RolNavigation);

            // Apply search if searchString is provided
            if (!String.IsNullOrEmpty(searchString))
            {
                usuarios = usuarios.Where(u => u.NombreUsuario.Contains(searchString) || u.CorreoElectronico.Contains(searchString));
            }

            // Apply sorting based on sortOrder parameter
            switch (sortOrder)
            {
                case "NombreAsc":
                    usuarios = usuarios.OrderBy(u => u.NombreUsuario);
                    break;
                case "NombreDesc":
                    usuarios = usuarios.OrderByDescending(u => u.NombreUsuario);
                    break;
                case "CorreoAsc":
                    usuarios = usuarios.OrderBy(u => u.CorreoElectronico);
                    break;
                case "CorreoDesc":
                    usuarios = usuarios.OrderByDescending(u => u.CorreoElectronico);
                    break;
                default:
                    usuarios = usuarios.OrderBy(u => u.NombreUsuario);
                    break;
            }
            return View(await usuarios.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.RolNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["Rol"] = new SelectList(_context.Roles, "IdRol", "IdRol");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreUsuario,CorreoElectronico,Rol")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Rol"] = new SelectList(_context.Roles, "IdRol", "IdRol", usuario.Rol);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["Rol"] = new SelectList(_context.Roles, "IdRol", "IdRol", usuario.Rol);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreUsuario,CorreoElectronico,Rol")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            ViewData["Rol"] = new SelectList(_context.Roles, "IdRol", "IdRol", usuario.Rol);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.RolNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
