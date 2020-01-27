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
    public class EstadoMascotasController : Controller
    {
        private readonly MascotasContext _context;

        public EstadoMascotasController(MascotasContext context)
        {
            _context = context;
        }

        // GET: EstadoMascotas
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadoMascotas.ToListAsync());
        }

        // GET: EstadoMascotas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoMascota = await _context.EstadoMascotas
                .FirstOrDefaultAsync(m => m.IDestadoMascota == id);
            if (estadoMascota == null)
            {
                return NotFound();
            }

            return View(estadoMascota);
        }

        // GET: EstadoMascotas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoMascotas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDestadoMascota,Aprobacion")] EstadoMascota estadoMascota)
        {
            if (ModelState.IsValid)
            {
                estadoMascota.IDestadoMascota = Guid.NewGuid();
                _context.Add(estadoMascota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadoMascota);
        }

        // GET: EstadoMascotas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoMascota = await _context.EstadoMascotas.FindAsync(id);
            if (estadoMascota == null)
            {
                return NotFound();
            }
            return View(estadoMascota);
        }

        // POST: EstadoMascotas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDestadoMascota,Aprobacion")] EstadoMascota estadoMascota)
        {
            if (id != estadoMascota.IDestadoMascota)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoMascota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoMascotaExists(estadoMascota.IDestadoMascota))
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
            return View(estadoMascota);
        }

        // GET: EstadoMascotas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoMascota = await _context.EstadoMascotas
                .FirstOrDefaultAsync(m => m.IDestadoMascota == id);
            if (estadoMascota == null)
            {
                return NotFound();
            }

            return View(estadoMascota);
        }

        // POST: EstadoMascotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var estadoMascota = await _context.EstadoMascotas.FindAsync(id);
            _context.EstadoMascotas.Remove(estadoMascota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoMascotaExists(Guid id)
        {
            return _context.EstadoMascotas.Any(e => e.IDestadoMascota == id);
        }
    }
}
