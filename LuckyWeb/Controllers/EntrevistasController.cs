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
    public class EntrevistasController : Controller
    {
        private readonly MascotasContext _context;

        public EntrevistasController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Entrevistas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entrevistas.ToListAsync());
        }

        // GET: Entrevistas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrevista = await _context.Entrevistas
                .FirstOrDefaultAsync(m => m.IDentrevistas == id);
            if (entrevista == null)
            {
                return NotFound();
            }

            return View(entrevista);
        }

        // GET: Entrevistas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entrevistas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDentrevistas")] Entrevista entrevista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entrevista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entrevista);
        }

        // GET: Entrevistas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrevista = await _context.Entrevistas.FindAsync(id);
            if (entrevista == null)
            {
                return NotFound();
            }
            return View(entrevista);
        }

        // POST: Entrevistas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDentrevistas")] Entrevista entrevista)
        {
            if (id != entrevista.IDentrevistas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entrevista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntrevistaExists(entrevista.IDentrevistas))
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
            return View(entrevista);
        }

        // GET: Entrevistas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrevista = await _context.Entrevistas
                .FirstOrDefaultAsync(m => m.IDentrevistas == id);
            if (entrevista == null)
            {
                return NotFound();
            }

            return View(entrevista);
        }

        // POST: Entrevistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entrevista = await _context.Entrevistas.FindAsync(id);
            _context.Entrevistas.Remove(entrevista);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntrevistaExists(int id)
        {
            return _context.Entrevistas.Any(e => e.IDentrevistas == id);
        }
    }
}