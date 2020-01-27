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
    public class Respuestas10Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas10Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas10
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas10.ToListAsync());
        }

        // GET: Respuestas10/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta10 = await _context.Respuestas10
                .FirstOrDefaultAsync(m => m.IDrespuesta10 == id);
            if (respuesta10 == null)
            {
                return NotFound();
            }

            return View(respuesta10);
        }

        // GET: Respuestas10/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas10/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta10,Respuesta")] Respuesta10 respuesta10)
        {
            if (ModelState.IsValid)
            {
                respuesta10.IDrespuesta10 = Guid.NewGuid();
                _context.Add(respuesta10);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta10);
        }

        // GET: Respuestas10/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta10 = await _context.Respuestas10.FindAsync(id);
            if (respuesta10 == null)
            {
                return NotFound();
            }
            return View(respuesta10);
        }

        // POST: Respuestas10/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta10,Respuesta")] Respuesta10 respuesta10)
        {
            if (id != respuesta10.IDrespuesta10)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta10);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta10Exists(respuesta10.IDrespuesta10))
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
            return View(respuesta10);
        }

        // GET: Respuestas10/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta10 = await _context.Respuestas10
                .FirstOrDefaultAsync(m => m.IDrespuesta10 == id);
            if (respuesta10 == null)
            {
                return NotFound();
            }

            return View(respuesta10);
        }

        // POST: Respuestas10/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta10 = await _context.Respuestas10.FindAsync(id);
            _context.Respuestas10.Remove(respuesta10);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta10Exists(Guid id)
        {
            return _context.Respuestas10.Any(e => e.IDrespuesta10 == id);
        }
    }
}
