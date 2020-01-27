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
    public class Respuesta1Controller : Controller
    {
        private readonly MascotasContext _context;

        public Respuesta1Controller(MascotasContext context)
        {
            _context = context;
        }

        // GET: Respuesta1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Respuestas1.ToListAsync());
        }

        // GET: Respuesta1/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta1 = await _context.Respuestas1
                .FirstOrDefaultAsync(m => m.IDrespuesta1 == id);
            if (respuesta1 == null)
            {
                return NotFound();
            }

            return View(respuesta1);
        }

        // GET: Respuesta1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respuesta1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDrespuesta1,Respuesta")] Respuesta1 respuesta1)
        {
            if (ModelState.IsValid)
            {
                respuesta1.IDrespuesta1 = Guid.NewGuid();
                _context.Add(respuesta1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta1);
        }

        // GET: Respuesta1/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta1 = await _context.Respuestas1.FindAsync(id);
            if (respuesta1 == null)
            {
                return NotFound();
            }
            return View(respuesta1);
        }

        // POST: Respuesta1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDrespuesta1,Respuesta")] Respuesta1 respuesta1)
        {
            if (id != respuesta1.IDrespuesta1)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respuesta1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Respuesta1Exists(respuesta1.IDrespuesta1))
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
            return View(respuesta1);
        }

        // GET: Respuesta1/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta1 = await _context.Respuestas1
                .FirstOrDefaultAsync(m => m.IDrespuesta1 == id);
            if (respuesta1 == null)
            {
                return NotFound();
            }

            return View(respuesta1);
        }

        // POST: Respuesta1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var respuesta1 = await _context.Respuestas1.FindAsync(id);
            _context.Respuestas1.Remove(respuesta1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Respuesta1Exists(Guid id)
        {
            return _context.Respuestas1.Any(e => e.IDrespuesta1 == id);
        }
    }
}
