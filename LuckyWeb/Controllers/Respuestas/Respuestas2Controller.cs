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
    public class Respuestas2Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas2Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas2.ToListAsync());
        }

        // GET: Respuestas2/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta2 = await _context.Respuestas2
                .FirstOrDefaultAsync(m => m.IDrespuesta2 == id);
            if (respuesta2 == null)
            {
                return NotFound();
            }

            return View(respuesta2);
        }

        // GET: Respuestas2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta2,Respuesta")] Respuesta2 respuesta2)
        {
            if (ModelState.IsValid)
            {
                respuesta2.IDrespuesta2 = Guid.NewGuid();
                _context.Add(respuesta2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta2);
        }

        // GET: Respuestas2/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta2 = await _context.Respuestas2.FindAsync(id);
            if (respuesta2 == null)
            {
                return NotFound();
            }
            return View(respuesta2);
        }

        // POST: Respuestas2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta2,Respuesta")] Respuesta2 respuesta2)
        {
            if (id != respuesta2.IDrespuesta2)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta2Exists(respuesta2.IDrespuesta2))
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
            return View(respuesta2);
        }

        // GET: Respuestas2/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta2 = await _context.Respuestas2
                .FirstOrDefaultAsync(m => m.IDrespuesta2 == id);
            if (respuesta2 == null)
            {
                return NotFound();
            }

            return View(respuesta2);
        }

        // POST: Respuestas2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta2 = await _context.Respuestas2.FindAsync(id);
            _context.Respuestas2.Remove(respuesta2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta2Exists(Guid id)
        {
            return _context.Respuestas2.Any(e => e.IDrespuesta2 == id);
        }
    }
}
