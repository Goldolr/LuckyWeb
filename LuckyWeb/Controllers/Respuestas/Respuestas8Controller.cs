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
    public class Respuestas8Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas8Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas8
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas8.ToListAsync());
        }

        // GET: Respuestas8/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta8 = await _context.Respuestas8
                .FirstOrDefaultAsync(m => m.IDrespuesta8 == id);
            if (respuesta8 == null)
            {
                return NotFound();
            }

            return View(respuesta8);
        }

        // GET: Respuestas8/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas8/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta8,Respuesta")] Respuesta8 respuesta8)
        {
            if (ModelState.IsValid)
            {
                respuesta8.IDrespuesta8 = Guid.NewGuid();
                _context.Add(respuesta8);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta8);
        }

        // GET: Respuestas8/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta8 = await _context.Respuestas8.FindAsync(id);
            if (respuesta8 == null)
            {
                return NotFound();
            }
            return View(respuesta8);
        }

        // POST: Respuestas8/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta8,Respuesta")] Respuesta8 respuesta8)
        {
            if (id != respuesta8.IDrespuesta8)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta8);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta8Exists(respuesta8.IDrespuesta8))
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
            return View(respuesta8);
        }

        // GET: Respuestas8/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta8 = await _context.Respuestas8
                .FirstOrDefaultAsync(m => m.IDrespuesta8 == id);
            if (respuesta8 == null)
            {
                return NotFound();
            }

            return View(respuesta8);
        }

        // POST: Respuestas8/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta8 = await _context.Respuestas8.FindAsync(id);
            _context.Respuestas8.Remove(respuesta8);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta8Exists(Guid id)
        {
            return _context.Respuestas8.Any(e => e.IDrespuesta8 == id);
        }
    }
}
