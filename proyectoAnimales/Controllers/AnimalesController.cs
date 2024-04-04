﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proyectoAnimales.Data;
using proyectoAnimales.Models;

namespace proyectoAnimales.Controllers
{
    public class AnimalesController : Controller
    {
        private readonly ProyectoAnimalesContext _context;

        public AnimalesController(ProyectoAnimalesContext context)
        {
            _context = context;
        }

        // GET: Animales
        public async Task<IActionResult> Index(int? numpag)
        {
            var proyectoAnimalesContext = _context.Animales.Include(a => a.Propietario);
            var animales = from animale in _context.Animales select animale;
            int cantidadregistros = 6;
            return View(await Paginacion<Animale>.CrearPaginacion(animales.AsNoTracking(), numpag ?? 1, cantidadregistros));
        }

        // GET: Animales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animale = await _context.Animales
                .Include(a => a.Propietario)
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animale == null)
            {
                return NotFound();
            }

            return View(animale);
        }

        // GET: Animales/Create
        public IActionResult Create()
        {
            ViewData["PropietarioId"] = new SelectList(_context.Propietarios, "PropietarioId", "PropietarioId");
            return View();
        }

        // POST: Animales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnimalId,Nombre,Especie,Edad,PropietarioId")] Animale animale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PropietarioId"] = new SelectList(_context.Propietarios, "PropietarioId", "PropietarioId", animale.PropietarioId);
            return View(animale);
        }

        // GET: Animales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animale = await _context.Animales.FindAsync(id);
            if (animale == null)
            {
                return NotFound();
            }
            ViewData["PropietarioId"] = new SelectList(_context.Propietarios, "PropietarioId", "PropietarioId", animale.PropietarioId);
            return View(animale);
        }

        // POST: Animales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AnimalId,Nombre,Especie,Edad,PropietarioId")] Animale animale)
        {
            if (id != animale.AnimalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(animale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimaleExists(animale.AnimalId))
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
            ViewData["PropietarioId"] = new SelectList(_context.Propietarios, "PropietarioId", "PropietarioId", animale.PropietarioId);
            return View(animale);
        }

        // GET: Animales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animale = await _context.Animales
                .Include(a => a.Propietario)
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animale == null)
            {
                return NotFound();
            }

            return View(animale);
        }

        // POST: Animales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animale = await _context.Animales.FindAsync(id);
            if (animale != null)
            {
                _context.Animales.Remove(animale);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimaleExists(int id)
        {
            return _context.Animales.Any(e => e.AnimalId == id);
        }
    }
}
