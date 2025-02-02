﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LuckyWeb.Context;
using LuckyWeb.Models;

namespace LuckyWeb.Controllers
{
    public class PruebasController : Controller
    {
        private readonly MascotasContext _context;

        public PruebasController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Pruebas
        public async Task<IActionResult> Index()
        {
            var mascotasContext = _context.Prueba.Include(p => p.FK_EntrevistaPrueba);
            return View(await mascotasContext.ToListAsync());
        }

        // GET: Pruebas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prueba = await _context.Prueba
                .Include(p => p.FK_EntrevistaPrueba)
                .FirstOrDefaultAsync(m => m.IDprueba == id);
            if (prueba == null)
            {
                return NotFound();
            }

            return View(prueba);
        }

        // GET: Pruebas/Create
        public IActionResult Create()
        {
            ViewData["IDentrevista"] = new SelectList(_context.Entrevistas, "IDentrevistas", "IDentrevistas");
            return View();
        }

        // POST: Pruebas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDprueba,EstadoPrueba,IDentrevista")] Prueba prueba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prueba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDentrevista"] = new SelectList(_context.Entrevistas, "IDentrevistas", "IDentrevistas", prueba.IDentrevista);
            return View(prueba);
        }

        // GET: Pruebas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prueba = await _context.Prueba.FindAsync(id);
            if (prueba == null)
            {
                return NotFound();
            }
            ViewData["IDentrevista"] = new SelectList(_context.Entrevistas, "IDentrevistas", "IDentrevistas", prueba.IDentrevista);
            return View(prueba);
        }

        // POST: Pruebas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDprueba,EstadoPrueba,IDentrevista")] Prueba prueba)
        {
            if (id != prueba.IDprueba)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prueba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PruebaExists(prueba.IDprueba))
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
            ViewData["IDentrevista"] = new SelectList(_context.Entrevistas, "IDentrevistas", "IDentrevistas", prueba.IDentrevista);
            return View(prueba);
        }

        // GET: Pruebas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prueba = await _context.Prueba
                .Include(p => p.FK_EntrevistaPrueba)
                .FirstOrDefaultAsync(m => m.IDprueba == id);
            if (prueba == null)
            {
                return NotFound();
            }

            return View(prueba);
        }

        // POST: Pruebas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prueba = await _context.Prueba.FindAsync(id);
            _context.Prueba.Remove(prueba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PruebaExists(int id)
        {
            return _context.Prueba.Any(e => e.IDprueba == id);
        }
    }
}
