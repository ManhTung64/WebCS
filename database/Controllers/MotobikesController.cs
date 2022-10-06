using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using database.Data;
using database.Models;

namespace database.Controllers
{
    public class MotobikesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MotobikesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Motobikes
        public async Task<IActionResult> Index()
        {
            return View(await _context.motobikes.ToListAsync());
        }

        // GET: Motobikes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motobike = await _context.motobikes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motobike == null)
            {
                return NotFound();
            }

            return View(motobike);
        }

        // GET: Motobikes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motobikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Model,Brand,Color,Price,Year")] Motobike motobike)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motobike);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motobike);
        }

        // GET: Motobikes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motobike = await _context.motobikes.FindAsync(id);
            if (motobike == null)
            {
                return NotFound();
            }
            return View(motobike);
        }

        // POST: Motobikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Model,Brand,Color,Price,Year")] Motobike motobike)
        {
            if (id != motobike.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motobike);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotobikeExists(motobike.Id))
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
            return View(motobike);
        }

        // GET: Motobikes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motobike = await _context.motobikes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motobike == null)
            {
                return NotFound();
            }

            return View(motobike);
        }

        // POST: Motobikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motobike = await _context.motobikes.FindAsync(id);
            _context.motobikes.Remove(motobike);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotobikeExists(int id)
        {
            return _context.motobikes.Any(e => e.Id == id);
        }
    }
}
