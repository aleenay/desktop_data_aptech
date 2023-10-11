using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication5test.Data;
using WebApplication5test.Models;

namespace WebApplication5test.Controllers
{
    public class TblStdsController : Controller
    {
        private readonly db_empContext _context;

        public TblStdsController(db_empContext context)
        {
            _context = context;
        }

        // GET: TblStds
        public async Task<IActionResult> Index()
        {
            var db_empContext = _context.TblStds.Include(t => t.CityNavigation);
            return View(await db_empContext.ToListAsync());
        }

        // GET: TblStds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblStds == null)
            {
                return NotFound();
            }

            var tblStd = await _context.TblStds
                .Include(t => t.CityNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblStd == null)
            {
                return NotFound();
            }

            return View(tblStd);
        }

        // GET: TblStds/Create
        public IActionResult Create()
        {
            ViewData["City"] = new SelectList(_context.TblCities, "Id", "Name");
            return View();
        }

        // POST: TblStds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,City")] TblStd tblStd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblStd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["City"] = new SelectList(_context.TblCities, "Id", "Name", tblStd.City);
            return View(tblStd);
        }

        // GET: TblStds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblStds == null)
            {
                return NotFound();
            }

            var tblStd = await _context.TblStds.FindAsync(id);
            if (tblStd == null)
            {
                return NotFound();
            }
            ViewData["City"] = new SelectList(_context.TblCities, "Id", "Id", tblStd.City);
            return View(tblStd);
        }

        // POST: TblStds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,City")] TblStd tblStd)
        {
            if (id != tblStd.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblStd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblStdExists(tblStd.Id))
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
            ViewData["City"] = new SelectList(_context.TblCities, "Id", "Id", tblStd.City);
            return View(tblStd);
        }

        // GET: TblStds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblStds == null)
            {
                return NotFound();
            }

            var tblStd = await _context.TblStds
                .Include(t => t.CityNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblStd == null)
            {
                return NotFound();
            }

            return View(tblStd);
        }

        // POST: TblStds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblStds == null)
            {
                return Problem("Entity set 'db_empContext.TblStds'  is null.");
            }
            var tblStd = await _context.TblStds.FindAsync(id);
            if (tblStd != null)
            {
                _context.TblStds.Remove(tblStd);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblStdExists(int id)
        {
          return (_context.TblStds?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
