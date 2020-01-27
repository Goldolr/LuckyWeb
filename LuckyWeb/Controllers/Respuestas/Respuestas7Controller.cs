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
    public class Respuestas7Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas7Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas7
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas7.ToListAsync());
        }

        // GET: Respuestas7/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta7 = await _context.Respuestas7
                .FirstOrDefaultAsync(m => m.IDrespuesta7 == id);
            if (respuesta7 == null)
            {
                return NotFound();
            }

            return View(respuesta7);
        }

        // GET: Respuestas7/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas7/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta7,Respuesta")] Respuesta7 respuesta7)
        {
            if (ModelState.IsValid)
            {
                respuesta7.IDrespuesta7 = Guid.NewGuid();
                _context.Add(respuesta7);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta7);
        }

        // GET: Respuestas7/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta7 = await _context.Respuestas7.FindAsync(id);
            if (respuesta7 == null)
            {
                return NotFound();
            }
            return View(respuesta7);
        }

        // POST: Respuestas7/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta7,Respuesta")] Respuesta7 respuesta7)
        {
            if (id != respuesta7.IDrespuesta7)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta7);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta7Exists(respuesta7.IDrespuesta7))
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
            return View(respuesta7);
        }

        // GET: Respuestas7/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta7 = await _context.Respuestas7
                .FirstOrDefaultAsync(m => m.IDrespuesta7 == id);
            if (respuesta7 == null)
            {
                return NotFound();
            }

            return View(respuesta7);
        }

        // POST: Respuestas7/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta7 = await _context.Respuestas7.FindAsync(id);
            _context.Respuestas7.Remove(respuesta7);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta7Exists(Guid id)
        {
            return _context.Respuestas7.Any(e => e.IDrespuesta7 == id);
        }
    }
}
