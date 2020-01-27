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
    public class Respuestas3Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuestas3Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuestas3
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas3.ToListAsync());
        }

        // GET: Respuestas3/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta3 = await _context.Respuestas3
                .FirstOrDefaultAsync(m => m.IDrespuesta3 == id);
            if (respuesta3 == null)
            {
                return NotFound();
            }

            return View(respuesta3);
        }

        // GET: Respuestas3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuestas3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta3,Respuesta")] Respuesta3 respuesta3)
        {
            if (ModelState.IsValid)
            {
                respuesta3.IDrespuesta3 = Guid.NewGuid();
                _context.Add(respuesta3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta3);
        }

        // GET: Respuestas3/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta3 = await _context.Respuestas3.FindAsync(id);
            if (respuesta3 == null)
            {
                return NotFound();
            }
            return View(respuesta3);
        }

        // POST: Respuestas3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta3,Respuesta")] Respuesta3 respuesta3)
        {
            if (id != respuesta3.IDrespuesta3)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta3Exists(respuesta3.IDrespuesta3))
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
            return View(respuesta3);
        }

        // GET: Respuestas3/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta3 = await _context.Respuestas3
                .FirstOrDefaultAsync(m => m.IDrespuesta3 == id);
            if (respuesta3 == null)
            {
                return NotFound();
            }

            return View(respuesta3);
        }

        // POST: Respuestas3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta3 = await _context.Respuestas3.FindAsync(id);
            _context.Respuestas3.Remove(respuesta3);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta3Exists(Guid id)
        {
            return _context.Respuestas3.Any(e => e.IDrespuesta3 == id);
        }
    }
}
