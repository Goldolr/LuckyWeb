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
    public class AgendaController : Controller
    {
        private readonly MascotasContext _context;

        public AgendaController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Agenda
        public async Task<IActionResult> Index()
        {
            var mascotasContext = _context.Agendas.Include(a => a.FK_UserAgenda);
            return View(await mascotasContext.ToListAsync());
        }

        // GET: Agenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendas
                .Include(a => a.FK_UserAgenda)
                .FirstOrDefaultAsync(m => m.IDagenda == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // GET: Agenda/Create
        public IActionResult Create()
        {
            ViewData["IDuser"] = new SelectList(_context.Users, "IdUser", "IdUser");
            return View();
        }

        // POST: Agenda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDagenda,FechaAgenda,IDuser")] Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDuser"] = new SelectList(_context.Users, "IdUser", "IdUser", agenda.IDuser);
            return View(agenda);
        }

        // GET: Agenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendas.FindAsync(id);
            if (agenda == null)
            {
                return NotFound();
            }
            ViewData["IDuser"] = new SelectList(_context.Users, "IdUser", "IdUser", agenda.IDuser);
            return View(agenda);
        }

        // POST: Agenda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDagenda,FechaAgenda,IDuser")] Agenda agenda)
        {
            if (id != agenda.IDagenda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendaExists(agenda.IDagenda))
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
            ViewData["IDuser"] = new SelectList(_context.Users, "IdUser", "IdUser", agenda.IDuser);
            return View(agenda);
        }

        // GET: Agenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendas
                .Include(a => a.FK_UserAgenda)
                .FirstOrDefaultAsync(m => m.IDagenda == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // POST: Agenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agenda = await _context.Agendas.FindAsync(id);
            _context.Agendas.Remove(agenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendaExists(int id)
        {
            return _context.Agendas.Any(e => e.IDagenda == id);
        }
    }
}
