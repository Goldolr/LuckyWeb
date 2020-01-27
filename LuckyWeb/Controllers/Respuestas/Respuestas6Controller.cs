using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LuckyWeb.Context;
using LuckyWeb.Models.Respuestas;

namespace LuckyWeb.Controllers.Respuestas
{
    public class Respuestas6Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas6Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas6
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas6.ToListAsync());
        }

        // GET: Respuestas6/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta6 = await _context.Respuestas6
                .FirstOrDefaultAsync(m => m.IDrespuesta6 == id);
            if (respuesta6 == null)
            {
                return NotFound();
            }

            return View(respuesta6);
        }

        // GET: Respuestas6/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas6/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta6,Respuesta")] Respuesta6 respuesta6)
        {
            if (ModelState.IsValid)
            {
                respuesta6.IDrespuesta6 = Guid.NewGuid();
                _context.Add(respuesta6);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta6);
        }

        // GET: Respuestas6/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta6 = await _context.Respuestas6.FindAsync(id);
            if (respuesta6 == null)
            {
                return NotFound();
            }
            return View(respuesta6);
        }

        // POST: Respuestas6/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta6,Respuesta")] Respuesta6 respuesta6)
        {
            if (id != respuesta6.IDrespuesta6)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta6);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta6Exists(respuesta6.IDrespuesta6))
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
            return View(respuesta6);
        }

        // GET: Respuestas6/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta6 = await _context.Respuestas6
                .FirstOrDefaultAsync(m => m.IDrespuesta6 == id);
            if (respuesta6 == null)
            {
                return NotFound();
            }

            return View(respuesta6);
        }

        // POST: Respuestas6/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta6 = await _context.Respuestas6.FindAsync(id);
            _context.Respuestas6.Remove(respuesta6);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta6Exists(Guid id)
        {
            return _context.Respuestas6.Any(e => e.IDrespuesta6 == id);
        }
    }
}
