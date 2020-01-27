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
    public class PreguntasController : Controller
    {
        private readonly MascotasContext _context;

        public PreguntasController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Preguntas
        public async Task<IActionResult> Index()
        {
            var mascotasContext = _context.Preguntas.Include(p => p.FK_Respuesta10Pregunta).Include(p => p.FK_Respuesta1Pregunta).Include(p => p.FK_Respuesta2Pregunta).Include(p => p.FK_Respuesta3Pregunta).Include(p => p.FK_Respuesta4Pregunta).Include(p => p.FK_Respuesta5Pregunta).Include(p => p.FK_Respuesta6Pregunta).Include(p => p.FK_Respuesta7Pregunta).Include(p => p.FK_Respuesta8Pregunta).Include(p => p.FK_Respuesta9Pregunta);
            return View(await mascotasContext.ToListAsync());
        }

        // GET: Preguntas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregunta = await _context.Preguntas
                .Include(p => p.FK_Respuesta10Pregunta)
                .Include(p => p.FK_Respuesta1Pregunta)
                .Include(p => p.FK_Respuesta2Pregunta)
                .Include(p => p.FK_Respuesta3Pregunta)
                .Include(p => p.FK_Respuesta4Pregunta)
                .Include(p => p.FK_Respuesta5Pregunta)
                .Include(p => p.FK_Respuesta6Pregunta)
                .Include(p => p.FK_Respuesta7Pregunta)
                .Include(p => p.FK_Respuesta8Pregunta)
                .Include(p => p.FK_Respuesta9Pregunta)
                .FirstOrDefaultAsync(m => m.IDpreguntas == id);
            if (pregunta == null)
            {
                return NotFound();
            }

            return View(pregunta);
        }

        // GET: Preguntas/Create
        public IActionResult Create()
        {
            ViewData["IDrespuesta10"] = new SelectList(_context.Respuestas10, "IDrespuesta10", "IDrespuesta10");
            ViewData["IDrespuesta1"] = new SelectList(_context.Respuestas1, "IDrespuesta1", "IDrespuesta1");
            ViewData["IDrespuesta2"] = new SelectList(_context.Respuestas2, "IDrespuesta2", "IDrespuesta2");
            ViewData["IDrespuesta3"] = new SelectList(_context.Respuestas3, "IDrespuesta3", "IDrespuesta3");
            ViewData["IDrespuesta4"] = new SelectList(_context.Respuestas4, "IDrespuesta4", "IDrespuesta4");
            ViewData["IDrespuesta5"] = new SelectList(_context.Respuestas5, "IDrespuesta5", "IDrespuesta5");
            ViewData["IDrespuesta6"] = new SelectList(_context.Respuestas6, "IDrespuesta6", "IDrespuesta6");
            ViewData["IDrespuesta7"] = new SelectList(_context.Respuestas7, "IDrespuesta7", "IDrespuesta7");
            ViewData["IDrespuesta8"] = new SelectList(_context.Respuestas8, "IDrespuesta8", "IDrespuesta8");
            ViewData["IDrespuesta9"] = new SelectList(_context.Respuestas9, "IDrespuesta9", "IDrespuesta9");
            return View();
        }

        // POST: Preguntas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDpreguntas,EstadoPreguntas,IDrespuesta1,IDrespuesta2,IDrespuesta3,IDrespuesta4,IDrespuesta5,IDrespuesta6,IDrespuesta7,IDrespuesta8,IDrespuesta9,IDrespuesta10")] Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                pregunta.IDpreguntas = Guid.NewGuid();
                _context.Add(pregunta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDrespuesta10"] = new SelectList(_context.Respuestas10, "IDrespuesta10", "IDrespuesta10", pregunta.IDrespuesta10);
            ViewData["IDrespuesta1"] = new SelectList(_context.Respuestas1, "IDrespuesta1", "IDrespuesta1", pregunta.IDrespuesta1);
            ViewData["IDrespuesta2"] = new SelectList(_context.Respuestas2, "IDrespuesta2", "IDrespuesta2", pregunta.IDrespuesta2);
            ViewData["IDrespuesta3"] = new SelectList(_context.Respuestas3, "IDrespuesta3", "IDrespuesta3", pregunta.IDrespuesta3);
            ViewData["IDrespuesta4"] = new SelectList(_context.Respuestas4, "IDrespuesta4", "IDrespuesta4", pregunta.IDrespuesta4);
            ViewData["IDrespuesta5"] = new SelectList(_context.Respuestas5, "IDrespuesta5", "IDrespuesta5", pregunta.IDrespuesta5);
            ViewData["IDrespuesta6"] = new SelectList(_context.Respuestas6, "IDrespuesta6", "IDrespuesta6", pregunta.IDrespuesta6);
            ViewData["IDrespuesta7"] = new SelectList(_context.Respuestas7, "IDrespuesta7", "IDrespuesta7", pregunta.IDrespuesta7);
            ViewData["IDrespuesta8"] = new SelectList(_context.Respuestas8, "IDrespuesta8", "IDrespuesta8", pregunta.IDrespuesta8);
            ViewData["IDrespuesta9"] = new SelectList(_context.Respuestas9, "IDrespuesta9", "IDrespuesta9", pregunta.IDrespuesta9);
            return View(pregunta);
        }

        // GET: Preguntas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregunta = await _context.Preguntas.FindAsync(id);
            if (pregunta == null)
            {
                return NotFound();
            }
            ViewData["IDrespuesta10"] = new SelectList(_context.Respuestas10, "IDrespuesta10", "IDrespuesta10", pregunta.IDrespuesta10);
            ViewData["IDrespuesta1"] = new SelectList(_context.Respuestas1, "IDrespuesta1", "IDrespuesta1", pregunta.IDrespuesta1);
            ViewData["IDrespuesta2"] = new SelectList(_context.Respuestas2, "IDrespuesta2", "IDrespuesta2", pregunta.IDrespuesta2);
            ViewData["IDrespuesta3"] = new SelectList(_context.Respuestas3, "IDrespuesta3", "IDrespuesta3", pregunta.IDrespuesta3);
            ViewData["IDrespuesta4"] = new SelectList(_context.Respuestas4, "IDrespuesta4", "IDrespuesta4", pregunta.IDrespuesta4);
            ViewData["IDrespuesta5"] = new SelectList(_context.Respuestas5, "IDrespuesta5", "IDrespuesta5", pregunta.IDrespuesta5);
            ViewData["IDrespuesta6"] = new SelectList(_context.Respuestas6, "IDrespuesta6", "IDrespuesta6", pregunta.IDrespuesta6);
            ViewData["IDrespuesta7"] = new SelectList(_context.Respuestas7, "IDrespuesta7", "IDrespuesta7", pregunta.IDrespuesta7);
            ViewData["IDrespuesta8"] = new SelectList(_context.Respuestas8, "IDrespuesta8", "IDrespuesta8", pregunta.IDrespuesta8);
            ViewData["IDrespuesta9"] = new SelectList(_context.Respuestas9, "IDrespuesta9", "IDrespuesta9", pregunta.IDrespuesta9);
            return View(pregunta);
        }

        // POST: Preguntas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IDpreguntas,EstadoPreguntas,IDrespuesta1,IDrespuesta2,IDrespuesta3,IDrespuesta4,IDrespuesta5,IDrespuesta6,IDrespuesta7,IDrespuesta8,IDrespuesta9,IDrespuesta10")] Pregunta pregunta)
        {
            if (id != pregunta.IDpreguntas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pregunta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreguntaExists(pregunta.IDpreguntas))
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
            ViewData["IDrespuesta10"] = new SelectList(_context.Respuestas10, "IDrespuesta10", "IDrespuesta10", pregunta.IDrespuesta10);
            ViewData["IDrespuesta1"] = new SelectList(_context.Respuestas1, "IDrespuesta1", "IDrespuesta1", pregunta.IDrespuesta1);
            ViewData["IDrespuesta2"] = new SelectList(_context.Respuestas2, "IDrespuesta2", "IDrespuesta2", pregunta.IDrespuesta2);
            ViewData["IDrespuesta3"] = new SelectList(_context.Respuestas3, "IDrespuesta3", "IDrespuesta3", pregunta.IDrespuesta3);
            ViewData["IDrespuesta4"] = new SelectList(_context.Respuestas4, "IDrespuesta4", "IDrespuesta4", pregunta.IDrespuesta4);
            ViewData["IDrespuesta5"] = new SelectList(_context.Respuestas5, "IDrespuesta5", "IDrespuesta5", pregunta.IDrespuesta5);
            ViewData["IDrespuesta6"] = new SelectList(_context.Respuestas6, "IDrespuesta6", "IDrespuesta6", pregunta.IDrespuesta6);
            ViewData["IDrespuesta7"] = new SelectList(_context.Respuestas7, "IDrespuesta7", "IDrespuesta7", pregunta.IDrespuesta7);
            ViewData["IDrespuesta8"] = new SelectList(_context.Respuestas8, "IDrespuesta8", "IDrespuesta8", pregunta.IDrespuesta8);
            ViewData["IDrespuesta9"] = new SelectList(_context.Respuestas9, "IDrespuesta9", "IDrespuesta9", pregunta.IDrespuesta9);
            return View(pregunta);
        }

        // GET: Preguntas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregunta = await _context.Preguntas
                .Include(p => p.FK_Respuesta10Pregunta)
                .Include(p => p.FK_Respuesta1Pregunta)
                .Include(p => p.FK_Respuesta2Pregunta)
                .Include(p => p.FK_Respuesta3Pregunta)
                .Include(p => p.FK_Respuesta4Pregunta)
                .Include(p => p.FK_Respuesta5Pregunta)
                .Include(p => p.FK_Respuesta6Pregunta)
                .Include(p => p.FK_Respuesta7Pregunta)
                .Include(p => p.FK_Respuesta8Pregunta)
                .Include(p => p.FK_Respuesta9Pregunta)
                .FirstOrDefaultAsync(m => m.IDpreguntas == id);
            if (pregunta == null)
            {
                return NotFound();
            }

            return View(pregunta);
        }

        // POST: Preguntas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pregunta = await _context.Preguntas.FindAsync(id);
            _context.Preguntas.Remove(pregunta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PreguntaExists(Guid id)
        {
            return _context.Preguntas.Any(e => e.IDpreguntas == id);
        }
    }
}
