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
    public class FormularioEncuestasController : Controller
    {
        private readonly MascotasContext _context;

        public FormularioEncuestasController(MascotasContext context)
        {
            _context = context;
        }

        // GET: FormularioEncuestas
        public async Task<IActionResult> Index()
        {
            var mascotasContext = _context.FormularioEncuestas.Include(f => f.FK_MascotaFormularioEncuesta).Include(f => f.FK_PreguntaFormularioEncuesta).Include(f => f.FK_UserFormularioEncuesta);
            return View(await mascotasContext.ToListAsync());
        }

        // GET: FormularioEncuestas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formularioEncuesta = await _context.FormularioEncuestas
                .Include(f => f.FK_MascotaFormularioEncuesta)
                .Include(f => f.FK_PreguntaFormularioEncuesta)
                .Include(f => f.FK_UserFormularioEncuesta)
                .FirstOrDefaultAsync(m => m.IDformularioEncuesta == id);
            if (formularioEncuesta == null)
            {
                return NotFound();
            }

            return View(formularioEncuesta);
        }

        // GET: FormularioEncuestas/Create
        public IActionResult Create()
        {
            ViewData["IDmascota"] = new SelectList(_context.Mascotas, "IdMascota", "NombreMascota");
            ViewData["IDpreguntas"] = new SelectList(_context.Preguntas, "IDpreguntas", "EstadoPreguntas");
            ViewData["IDuser"] = new SelectList(_context.Users, "IdUser", "Nombre");
            return View();
        }

        // POST: FormularioEncuestas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDformularioEncuesta,IDuser,IDmascota,IDpreguntas")] FormularioEncuesta formularioEncuesta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formularioEncuesta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDmascota"] = new SelectList(_context.Mascotas, "IdMascota", "NombreMascota", formularioEncuesta.IDmascota);
            ViewData["IDpreguntas"] = new SelectList(_context.Preguntas, "IDpreguntas", "EstadoPreguntas", formularioEncuesta.IDpreguntas);
            ViewData["IDuser"] = new SelectList(_context.Users, "IdUser", "Nombre", formularioEncuesta.IDuser);
            return View(formularioEncuesta);
        }

        // GET: FormularioEncuestas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formularioEncuesta = await _context.FormularioEncuestas.FindAsync(id);
            if (formularioEncuesta == null)
            {
                return NotFound();
            }
            ViewData["IDmascota"] = new SelectList(_context.Mascotas, "IdMascota", "NombreMascota", formularioEncuesta.IDmascota);
            ViewData["IDpreguntas"] = new SelectList(_context.Preguntas, "IDpreguntas", "IDpreguntas", formularioEncuesta.IDpreguntas);
            ViewData["IDuser"] = new SelectList(_context.Users, "IdUser", "Apellido", formularioEncuesta.IDuser);
            return View(formularioEncuesta);
        }

        // POST: FormularioEncuestas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDformularioEncuesta,IDuser,IDmascota,IDpreguntas")] FormularioEncuesta formularioEncuesta)
        {
            if (id != formularioEncuesta.IDformularioEncuesta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formularioEncuesta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormularioEncuestaExists(formularioEncuesta.IDformularioEncuesta))
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
            ViewData["IDmascota"] = new SelectList(_context.Mascotas, "IdMascota", "NombreMascota", formularioEncuesta.IDmascota);
            ViewData["IDpreguntas"] = new SelectList(_context.Preguntas, "IDpreguntas", "IDpreguntas", formularioEncuesta.IDpreguntas);
            ViewData["IDuser"] = new SelectList(_context.Users, "IdUser", "Apellido", formularioEncuesta.IDuser);
            return View(formularioEncuesta);
        }

        // GET: FormularioEncuestas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formularioEncuesta = await _context.FormularioEncuestas
                .Include(f => f.FK_MascotaFormularioEncuesta)
                .Include(f => f.FK_PreguntaFormularioEncuesta)
                .Include(f => f.FK_UserFormularioEncuesta)
                .FirstOrDefaultAsync(m => m.IDformularioEncuesta == id);
            if (formularioEncuesta == null)
            {
                return NotFound();
            }

            return View(formularioEncuesta);
        }

        // POST: FormularioEncuestas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formularioEncuesta = await _context.FormularioEncuestas.FindAsync(id);
            _context.FormularioEncuestas.Remove(formularioEncuesta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormularioEncuestaExists(int id)
        {
            return _context.FormularioEncuestas.Any(e => e.IDformularioEncuesta == id);
        }
    }
}
