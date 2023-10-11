using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using db_first_test.Data;
using db_first_test.Models;

namespace db_first_test.Controllers
{
    public class TblStdInfoesController : Controller
    {
        private readonly db_schoolContext _context;

        public TblStdInfoesController(db_schoolContext context)
        {
            _context = context;
        }

        // GET: TblStdInfoes
        public async Task<IActionResult> Index()
        {
              return _context.TblStdInfos != null ? 
                          View(await _context.TblStdInfos.ToListAsync()) :
                          Problem("Entity set 'db_schoolContext.TblStdInfos'  is null.");
        }

        // GET: TblStdInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblStdInfos == null)
            {
                return NotFound();
            }

            var tblStdInfo = await _context.TblStdInfos
                .FirstOrDefaultAsync(m => m.StdId == id);
            if (tblStdInfo == null)
            {
                return NotFound();
            }

            return View(tblStdInfo);
        }

        // GET: TblStdInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblStdInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StdId,StdName,StdAge,StdCity")] TblStdInfo tblStdInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblStdInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblStdInfo);
        }

        // GET: TblStdInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblStdInfos == null)
            {
                return NotFound();
            }

            var tblStdInfo = await _context.TblStdInfos.FindAsync(id);
            if (tblStdInfo == null)
            {
                return NotFound();
            }
            return View(tblStdInfo);
        }

        // POST: TblStdInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StdId,StdName,StdAge,StdCity")] TblStdInfo tblStdInfo)
        {
            if (id != tblStdInfo.StdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblStdInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblStdInfoExists(tblStdInfo.StdId))
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
            return View(tblStdInfo);
        }

        // GET: TblStdInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblStdInfos == null)
            {
                return NotFound();
            }

            var tblStdInfo = await _context.TblStdInfos
                .FirstOrDefaultAsync(m => m.StdId == id);
            if (tblStdInfo == null)
            {
                return NotFound();
            }

            return View(tblStdInfo);
        }

        // POST: TblStdInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblStdInfos == null)
            {
                return Problem("Entity set 'db_schoolContext.TblStdInfos'  is null.");
            }
            var tblStdInfo = await _context.TblStdInfos.FindAsync(id);
            if (tblStdInfo != null)
            {
                _context.TblStdInfos.Remove(tblStdInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblStdInfoExists(int id)
        {
          return (_context.TblStdInfos?.Any(e => e.StdId == id)).GetValueOrDefault();
        }
    }
}
