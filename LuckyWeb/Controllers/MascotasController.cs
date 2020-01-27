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
    public class MascotasController : Controller
    {
        private readonly MascotasContext _context;

        public MascotasController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Mascotas
        public async Task<IActionResult> Index(string NombreMascota)
        {
            if (!String.IsNullOrEmpty(NombreMascota))
            {
                var busqueda = _context.Mascotas.Where(_context => _context.NombreMascota.Contains(NombreMascota));
                return View(busqueda);
            }
            var mascotasContext = _context.Mascotas.Include(m => m.FK_EstadoMascotaMascota).Include(m => m.FK_EsterilizadoMascota).Include(m => m.FK_RazaMascota);
            return View(await mascotasContext.ToListAsync());
        }

        // GET: Mascotas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascota = await _context.Mascotas
                .Include(m => m.FK_EstadoMascotaMascota)
                .Include(m => m.FK_EsterilizadoMascota)
                .Include(m => m.FK_RazaMascota)
                .FirstOrDefaultAsync(m => m.IdMascota == id);
            if (mascota == null)
            {
                return NotFound();
            }

            return View(mascota);
        }

        // GET: Mascotas/Create
        public IActionResult Create()
        {
            ViewData["IDestadoMascota"] = new SelectList(_context.EstadoMascotas, "IDestadoMascota", "IDestadoMascota");
            ViewData["IDesterilizado"] = new SelectList(_context.Esterilizados, "IDesterilizad", "IDesterilizad");
            ViewData["IDraza"] = new SelectList(_context.Razas, "IDraza", "IDraza");
            return View();
        }

        // POST: Mascotas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMascota,NombreMascota,EdadMascota,IDraza,IDesterilizado,IDestadoMascota")] Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                mascota.IdMascota = Guid.NewGuid();
                _context.Add(mascota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDestadoMascota"] = new SelectList(_context.EstadoMascotas, "IDestadoMascota", "IDestadoMascota", mascota.IDestadoMascota);
            ViewData["IDesterilizado"] = new SelectList(_context.Esterilizados, "IDesterilizad", "IDesterilizad", mascota.IDesterilizado);
            ViewData["IDraza"] = new SelectList(_context.Razas, "IDraza", "IDraza", mascota.IDraza);
            return View(mascota);
        }

        // GET: Mascotas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascota = await _context.Mascotas.FindAsync(id);
            if (mascota == null)
            {
                return NotFound();
            }
            ViewData["IDestadoMascota"] = new SelectList(_context.EstadoMascotas, "IDestadoMascota", "IDestadoMascota", mascota.IDestadoMascota);
            ViewData["IDesterilizado"] = new SelectList(_context.Esterilizados, "IDesterilizad", "IDesterilizad", mascota.IDesterilizado);
            ViewData["IDraza"] = new SelectList(_context.Razas, "IDraza", "IDraza", mascota.IDraza);
            return View(mascota);
        }

        // POST: Mascotas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdMascota,NombreMascota,EdadMascota,IDraza,IDesterilizado,IDestadoMascota")] Mascota mascota)
        {
            if (id != mascota.IdMascota)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mascota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MascotaExists(mascota.IdMascota))
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
            ViewData["IDestadoMascota"] = new SelectList(_context.EstadoMascotas, "IDestadoMascota", "IDestadoMascota", mascota.IDestadoMascota);
            ViewData["IDesterilizado"] = new SelectList(_context.Esterilizados, "IDesterilizad", "IDesterilizad", mascota.IDesterilizado);
            ViewData["IDraza"] = new SelectList(_context.Razas, "IDraza", "IDraza", mascota.IDraza);
            return View(mascota);
        }

        // GET: Mascotas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascota = await _context.Mascotas
                .Include(m => m.FK_EstadoMascotaMascota)
                .Include(m => m.FK_EsterilizadoMascota)
                .Include(m => m.FK_RazaMascota)
                .FirstOrDefaultAsync(m => m.IdMascota == id);
            if (mascota == null)
            {
                return NotFound();
            }

            return View(mascota);
        }

        // POST: Mascotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var mascota = await _context.Mascotas.FindAsync(id);
            _context.Mascotas.Remove(mascota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MascotaExists(Guid id)
        {
            return _context.Mascotas.Any(e => e.IdMascota == id);
        }
    }
}
