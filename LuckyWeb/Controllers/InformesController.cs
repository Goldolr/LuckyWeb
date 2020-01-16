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
    public class InformesController : Controller
    {
        private readonly MascotasContext _context;

        public InformesController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Informes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Informes.ToListAsync());
        }

        // GET: Informes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informe = await _context.Informes
                .FirstOrDefaultAsync(m => m.IDinforme == id);
            if (informe == null)
            {
                return NotFound();
            }

            return View(informe);
        }

        // GET: Informes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Informes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDinforme")] Informe informe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(informe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(informe);
        }

        // GET: Informes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informe = await _context.Informes.FindAsync(id);
            if (informe == null)
            {
                return NotFound();
            }
            return View(informe);
        }

        // POST: Informes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDinforme")] Informe informe)
        {
            if (id != informe.IDinforme)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(informe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InformeExists(informe.IDinforme))
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
            return View(informe);
        }

        // GET: Informes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informe = await _context.Informes
                .FirstOrDefaultAsync(m => m.IDinforme == id);
            if (informe == null)
            {
                return NotFound();
            }

            return View(informe);
        }

        // POST: Informes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var informe = await _context.Informes.FindAsync(id);
            _context.Informes.Remove(informe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InformeExists(int id)
        {
            return _context.Informes.Any(e => e.IDinforme == id);
        }
    }
}
