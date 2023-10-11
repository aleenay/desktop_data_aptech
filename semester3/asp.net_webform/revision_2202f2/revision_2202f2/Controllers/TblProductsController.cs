using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using revision_2202f2.Data;
using revision_2202f2.Models;

namespace revision_2202f2.Controllers
{
    public class TblProductsController : Controller
    {
        private readonly db_ecommerceContext _context;

        public TblProductsController(db_ecommerceContext context)
        {
            _context = context;
        }

        // GET: TblProducts
        public async Task<IActionResult> Index()
        {
            var db_ecommerceContext = _context.TblProducts.Include(t => t.CIdNavigation);
            return View(await db_ecommerceContext.ToListAsync());
        }

        // GET: TblProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblProducts == null)
            {
                return NotFound();
            }

            var tblProduct = await _context.TblProducts
                .Include(t => t.CIdNavigation)
                .FirstOrDefaultAsync(m => m.PId == id);
            if (tblProduct == null)
            {
                return NotFound();
            }

            return View(tblProduct);
        }

        // GET: TblProducts/Create
        public IActionResult Create()
        {
            ViewData["CId"] = new SelectList(_context.TblCategories, "CId", "CId");
            return View();
        }

        // POST: TblProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,PName,PPrice,PDes,CId,PImg")] TblProduct tblProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CId"] = new SelectList(_context.TblCategories, "CId", "CId", tblProduct.CId);
            return View(tblProduct);
        }

        // GET: TblProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblProducts == null)
            {
                return NotFound();
            }

            var tblProduct = await _context.TblProducts.FindAsync(id);
            if (tblProduct == null)
            {
                return NotFound();
            }
            ViewData["CId"] = new SelectList(_context.TblCategories, "CId", "CId", tblProduct.CId);
            return View(tblProduct);
        }

        // POST: TblProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PId,PName,PPrice,PDes,CId,PImg")] TblProduct tblProduct)
        {
            if (id != tblProduct.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblProductExists(tblProduct.PId))
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
            ViewData["CId"] = new SelectList(_context.TblCategories, "CId", "CId", tblProduct.CId);
            return View(tblProduct);
        }

        // GET: TblProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblProducts == null)
            {
                return NotFound();
            }

            var tblProduct = await _context.TblProducts
                .Include(t => t.CIdNavigation)
                .FirstOrDefaultAsync(m => m.PId == id);
            if (tblProduct == null)
            {
                return NotFound();
            }

            return View(tblProduct);
        }

        // POST: TblProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblProducts == null)
            {
                return Problem("Entity set 'db_ecommerceContext.TblProducts'  is null.");
            }
            var tblProduct = await _context.TblProducts.FindAsync(id);
            if (tblProduct != null)
            {
                _context.TblProducts.Remove(tblProduct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblProductExists(int id)
        {
          return (_context.TblProducts?.Any(e => e.PId == id)).GetValueOrDefault();
        }
    }
}
