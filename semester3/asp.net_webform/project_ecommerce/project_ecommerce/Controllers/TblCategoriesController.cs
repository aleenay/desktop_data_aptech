using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project_ecommerce.Data;
using project_ecommerce.Models;

namespace project_ecommerce.Controllers
{
    public class TblCategoriesController : Controller
    {
        private readonly db_ecommerceContext _context;

        public TblCategoriesController(db_ecommerceContext context)
        {
            _context = context;
        }

        // GET: TblCategories
        public async Task<IActionResult> Index()
        {
              return _context.TblCategories != null ? 
                          View(await _context.TblCategories.ToListAsync()) :
                          Problem("Entity set 'db_ecommerceContext.TblCategories'  is null.");
        }

        // GET: TblCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblCategories == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.TblCategories
                .FirstOrDefaultAsync(m => m.CId == id);
            if (tblCategory == null)
            {
                return NotFound();
            }

            return View(tblCategory);
        }

        // GET: TblCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CId,CName")] TblCategory tblCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblCategory);
        }

        // GET: TblCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblCategories == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.TblCategories.FindAsync(id);
            if (tblCategory == null)
            {
                return NotFound();
            }
            return View(tblCategory);
        }

        // POST: TblCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CId,CName")] TblCategory tblCategory)
        {
            if (id != tblCategory.CId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblCategoryExists(tblCategory.CId))
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
            return View(tblCategory);
        }

        // GET: TblCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblCategories == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.TblCategories
                .FirstOrDefaultAsync(m => m.CId == id);
            if (tblCategory == null)
            {
                return NotFound();
            }

            return View(tblCategory);
        }

        // POST: TblCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblCategories == null)
            {
                return Problem("Entity set 'db_ecommerceContext.TblCategories'  is null.");
            }
            var tblCategory = await _context.TblCategories.FindAsync(id);
            if (tblCategory != null)
            {
                _context.TblCategories.Remove(tblCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblCategoryExists(int id)
        {
          return (_context.TblCategories?.Any(e => e.CId == id)).GetValueOrDefault();
        }
    }
}
