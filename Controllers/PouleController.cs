using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnfcGlog.Models;

namespace EnfcGlog.Controllers
{
    public class PouleController : Controller
    {
        private readonly EnfcGlogContext _context;

        public PouleController(EnfcGlogContext context)
        {
            _context = context;
        }

        // GET: Poule
        public async Task<IActionResult> Index()
        {
            return View(await _context.Poule.ToListAsync());
        }

        // GET: Poule/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poule = await _context.Poule
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poule == null)
            {
                return NotFound();
            }

            return View(poule);
        }

        // GET: Poule/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Poule/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Poule poule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poule);
        }

        // GET: Poule/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poule = await _context.Poule.FindAsync(id);
            if (poule == null)
            {
                return NotFound();
            }
            return View(poule);
        }

        // POST: Poule/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Poule poule)
        {
            if (id != poule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PouleExists(poule.Id))
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
            return View(poule);
        }

        // GET: Poule/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poule = await _context.Poule
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poule == null)
            {
                return NotFound();
            }

            return View(poule);
        }

        // POST: Poule/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poule = await _context.Poule.FindAsync(id);
            _context.Poule.Remove(poule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PouleExists(int id)
        {
            return _context.Poule.Any(e => e.Id == id);
        }
    }
}
