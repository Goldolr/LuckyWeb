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
    public class Respuestas5Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas5Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas5
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas5.ToListAsync());
        }

        // GET: Respuestas5/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta5 = await _context.Respuestas5
                .FirstOrDefaultAsync(m => m.IDrespuesta5 == id);
            if (respuesta5 == null)
            {
                return NotFound();
            }

            return View(respuesta5);
        }

        // GET: Respuestas5/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas5/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta5,Respuesta")] Respuesta5 respuesta5)
        {
            if (ModelState.IsValid)
            {
                respuesta5.IDrespuesta5 = Guid.NewGuid();
                _context.Add(respuesta5);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta5);
        }

        // GET: Respuestas5/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta5 = await _context.Respuestas5.FindAsync(id);
            if (respuesta5 == null)
            {
                return NotFound();
            }
            return View(respuesta5);
        }

        // POST: Respuestas5/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta5,Respuesta")] Respuesta5 respuesta5)
        {
            if (id != respuesta5.IDrespuesta5)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta5);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta5Exists(respuesta5.IDrespuesta5))
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
            return View(respuesta5);
        }

        // GET: Respuestas5/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta5 = await _context.Respuestas5
                .FirstOrDefaultAsync(m => m.IDrespuesta5 == id);
            if (respuesta5 == null)
            {
                return NotFound();
            }

            return View(respuesta5);
        }

        // POST: Respuestas5/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta5 = await _context.Respuestas5.FindAsync(id);
            _context.Respuestas5.Remove(respuesta5);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta5Exists(Guid id)
        {
            return _context.Respuestas5.Any(e => e.IDrespuesta5 == id);
        }
    }
}
