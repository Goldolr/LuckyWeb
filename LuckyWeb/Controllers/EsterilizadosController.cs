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
    public class EsterilizadosController : Controller
    {
        private readonly MascotasContext _context;

        public EsterilizadosController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Esterilizados
        public async Task<IActionResult> Index()
        {
            return View(await _context.Esterilizados.ToListAsync());
        }

        // GET: Esterilizados/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var esterilizado = await _context.Esterilizados
                .FirstOrDefaultAsync(m => m.IDesterilizad == id);
            if (esterilizado == null)
            {
                return NotFound();
            }

            return View(esterilizado);
        }

        // GET: Esterilizados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Esterilizados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDesterilizad,EstadoEsterilizado")] Esterilizado esterilizado)
        {
            if (ModelState.IsValid)
            {
                esterilizado.IDesterilizad = Guid.NewGuid();
                _context.Add(esterilizado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(esterilizado);
        }

        // GET: Esterilizados/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var esterilizado = await _context.Esterilizados.FindAsync(id);
            if (esterilizado == null)
            {
                return NotFound();
            }
            return View(esterilizado);
        }

        // POST: Esterilizados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDesterilizad,EstadoEsterilizado")] Esterilizado esterilizado)
        {
            if (id != esterilizado.IDesterilizad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(esterilizado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EsterilizadoExists(esterilizado.IDesterilizad))
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
            return View(esterilizado);
        }

        // GET: Esterilizados/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var esterilizado = await _context.Esterilizados
                .FirstOrDefaultAsync(m => m.IDesterilizad == id);
            if (esterilizado == null)
            {
                return NotFound();
            }

            return View(esterilizado);
        }

        // POST: Esterilizados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var esterilizado = await _context.Esterilizados.FindAsync(id);
            _context.Esterilizados.Remove(esterilizado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EsterilizadoExists(Guid id)
        {
            return _context.Esterilizados.Any(e => e.IDesterilizad == id);
        }
    }
}
