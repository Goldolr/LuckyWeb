using System;
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
    public class RazasController : Controller
    {
        private readonly MascotasContext _context;

        public RazasController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Razas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Razas.ToListAsync());
        }

        // GET: Razas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raza = await _context.Razas
                .FirstOrDefaultAsync(m => m.IDraza == id);
            if (raza == null)
            {
                return NotFound();
            }

            return View(raza);
        }

        // GET: Razas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Razas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDraza,RazaMascota")] Raza raza)
        {
            if (ModelState.IsValid)
            {
                raza.IDraza = Guid.NewGuid();
                _context.Add(raza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(raza);
        }

        // GET: Razas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raza = await _context.Razas.FindAsync(id);
            if (raza == null)
            {
                return NotFound();
            }
            return View(raza);
        }

        // POST: Razas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDraza,RazaMascota")] Raza raza)
        {
            if (id != raza.IDraza)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(raza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RazaExists(raza.IDraza))
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
            return View(raza);
        }

        // GET: Razas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raza = await _context.Razas
                .FirstOrDefaultAsync(m => m.IDraza == id);
            if (raza == null)
            {
                return NotFound();
            }

            return View(raza);
        }

        // POST: Razas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var raza = await _context.Razas.FindAsync(id);
            _context.Razas.Remove(raza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RazaExists(Guid id)
        {
            return _context.Razas.Any(e => e.IDraza == id);
        }
    }
}
