using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using crud_withimg.Data;
using crud_withimg.Models;

namespace crud_withimg.Controllers
{
    public class TblStdsController : Controller
    {
        private readonly db_2202f2Context _context;

        public TblStdsController(db_2202f2Context context)
        {
            _context = context;
        }

        // GET: TblStds
        public async Task<IActionResult> Index()
        {
           
            var db_2202f2Context = _context.TblStds.Include(t => t.StdCityNavigation);
            return View(await db_2202f2Context.ToListAsync());
        }

        // GET: TblStds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblStds == null)
            {
                return NotFound();
            }

            var tblStd = await _context.TblStds
                .Include(t => t.StdCityNavigation)
                .FirstOrDefaultAsync(m => m.StdId == id);
            if (tblStd == null)
            {
                return NotFound();
            }

            return View(tblStd);
        }

        // GET: TblStds/Create
        public IActionResult Create()
        {
            ViewData["StdCity"] = new SelectList(_context.TblCategories, "CId", "CId");
            return View();
        }

        // POST: TblStds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StdId,StdName,StdAge,StdEmail,StdCity,StdProfile")] TblStd tblStd, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                var imageName = Path.GetFileName(image.FileName);
                string imagePath = Path.Combine(HttpContext.Request.PathBase.Value, "wwwroot/image/");
                string imagevalue = Path.Combine(imagePath, imageName);
                using (var stream = new FileStream(imagevalue, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
                tblStd.StdProfile = "../../image/" + imageName;

                _context.Add(tblStd);
               
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StdCity"] = new SelectList(_context.TblCategories, "CId", "CId", tblStd.StdCity);
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
            ViewData["StdCity"] = new SelectList(_context.TblCategories, "CId", "CId", tblStd.StdCity);
            return View(tblStd);
        }

        // POST: TblStds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StdId,StdName,StdAge,StdEmail,StdCity,StdProfile")] TblStd tblStd)
        {
            if (id != tblStd.StdId)
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
                    if (!TblStdExists(tblStd.StdId))
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
            ViewData["StdCity"] = new SelectList(_context.TblCategories, "CId", "CId", tblStd.StdCity);
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
                .Include(t => t.StdCityNavigation)
                .FirstOrDefaultAsync(m => m.StdId == id);
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
                return Problem("Entity set 'db_2202f2Context.TblStds'  is null.");
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
          return (_context.TblStds?.Any(e => e.StdId == id)).GetValueOrDefault();
        }
    }
}
