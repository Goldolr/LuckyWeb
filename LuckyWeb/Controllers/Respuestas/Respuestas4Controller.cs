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
    public class Respuestas4Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas4Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas4
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas4.ToListAsync());
        }

        // GET: Respuestas4/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta4 = await _context.Respuestas4
                .FirstOrDefaultAsync(m => m.IDrespuesta4 == id);
            if (respuesta4 == null)
            {
                return NotFound();
            }

            return View(respuesta4);
        }

        // GET: Respuestas4/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas4/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta4,Respuesta")] Respuesta4 respuesta4)
        {
            if (ModelState.IsValid)
            {
                respuesta4.IDrespuesta4 = Guid.NewGuid();
                _context.Add(respuesta4);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta4);
        }

        // GET: Respuestas4/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta4 = await _context.Respuestas4.FindAsync(id);
            if (respuesta4 == null)
            {
                return NotFound();
            }
            return View(respuesta4);
        }

        // POST: Respuestas4/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta4,Respuesta")] Respuesta4 respuesta4)
        {
            if (id != respuesta4.IDrespuesta4)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta4);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta4Exists(respuesta4.IDrespuesta4))
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
            return View(respuesta4);
        }

        // GET: Respuestas4/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta4 = await _context.Respuestas4
                .FirstOrDefaultAsync(m => m.IDrespuesta4 == id);
            if (respuesta4 == null)
            {
                return NotFound();
            }

            return View(respuesta4);
        }

        // POST: Respuestas4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta4 = await _context.Respuestas4.FindAsync(id);
            _context.Respuestas4.Remove(respuesta4);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta4Exists(Guid id)
        {
            return _context.Respuestas4.Any(e => e.IDrespuesta4 == id);
        }
    }
}
