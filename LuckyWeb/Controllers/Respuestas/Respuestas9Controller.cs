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
    public class Respuestas9Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas9Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas9
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas9.ToListAsync());
        }

        // GET: Respuestas9/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta9 = await _context.Respuestas9
                .FirstOrDefaultAsync(m => m.IDrespuesta9 == id);
            if (respuesta9 == null)
            {
                return NotFound();
            }

            return View(respuesta9);
        }

        // GET: Respuestas9/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas9/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta9,Respuesta")] Respuesta9 respuesta9)
        {
            if (ModelState.IsValid)
            {
                respuesta9.IDrespuesta9 = Guid.NewGuid();
                _context.Add(respuesta9);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta9);
        }

        // GET: Respuestas9/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta9 = await _context.Respuestas9.FindAsync(id);
            if (respuesta9 == null)
            {
                return NotFound();
            }
            return View(respuesta9);
        }

        // POST: Respuestas9/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta9,Respuesta")] Respuesta9 respuesta9)
        {
            if (id != respuesta9.IDrespuesta9)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta9);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta9Exists(respuesta9.IDrespuesta9))
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
            return View(respuesta9);
        }

        // GET: Respuestas9/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta9 = await _context.Respuestas9
                .FirstOrDefaultAsync(m => m.IDrespuesta9 == id);
            if (respuesta9 == null)
            {
                return NotFound();
            }

            return View(respuesta9);
        }

        // POST: Respuestas9/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta9 = await _context.Respuestas9.FindAsync(id);
            _context.Respuestas9.Remove(respuesta9);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta9Exists(Guid id)
        {
            return _context.Respuestas9.Any(e => e.IDrespuesta9 == id);
        }
    }
}
