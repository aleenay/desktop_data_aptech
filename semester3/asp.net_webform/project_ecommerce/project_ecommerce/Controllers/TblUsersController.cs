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
    public class TblUsersController : Controller
    {
        private readonly db_ecommerceContext _context;

        public TblUsersController(db_ecommerceContext context)
        {
            _context = context;
        }

        // GET: TblUsers
        public async Task<IActionResult> Index()
        {
              return _context.TblUsers != null ? 
                          View(await _context.TblUsers.ToListAsync()) :
                          Problem("Entity set 'db_ecommerceContext.TblUsers'  is null.");
        }

        // GET: TblUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblUsers == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers
                .FirstOrDefaultAsync(m => m.UId == id);
            if (tblUser == null)
            {
                return NotFound();
            }

            return View(tblUser);
        }

        // GET: TblUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UId,UName,UEmail,UPassword,UPhoneno")] TblUser tblUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblUser);
        }

        // GET: TblUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblUsers == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers.FindAsync(id);
            if (tblUser == null)
            {
                return NotFound();
            }
            return View(tblUser);
        }

        // POST: TblUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UId,UName,UEmail,UPassword,UPhoneno")] TblUser tblUser)
        {
            if (id != tblUser.UId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblUserExists(tblUser.UId))
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
            return View(tblUser);
        }

        // GET: TblUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblUsers == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers
                .FirstOrDefaultAsync(m => m.UId == id);
            if (tblUser == null)
            {
                return NotFound();
            }

            return View(tblUser);
        }

        // POST: TblUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblUsers == null)
            {
                return Problem("Entity set 'db_ecommerceContext.TblUsers'  is null.");
            }
            var tblUser = await _context.TblUsers.FindAsync(id);
            if (tblUser != null)
            {
                _context.TblUsers.Remove(tblUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblUserExists(int id)
        {
          return (_context.TblUsers?.Any(e => e.UId == id)).GetValueOrDefault();
        }
    }
}
