using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_ecommerce.Data;
using project_ecommerce.Models;

namespace project_ecommerce.Controllers
{
    public class TestingController : Controller
    {
        private readonly db_ecommerceContext _context;
        private readonly  TblCart _cart;
        public TestingController(db_ecommerceContext context )
        {
            _context = context;
            
        }
        public async Task<IActionResult> Index()
        {
            return _context.TblCarts != null ?
                        View(await _context.TblCarts.ToListAsync()) :
                        Problem("Entity set 'db_ecommerceContext.TblCarts'  is null.");
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services22()
        {
            return View();
        }
        

        public async Task<IActionResult> FetchProducts ()
        {
            var db_ecommerceContext = _context.TblProducts.Include(t => t.CIdNavigation);
            return View(await db_ecommerceContext.ToListAsync());
        }
       
        public IActionResult add_to_cart(int id)
        {
            
            var cartItem = new TblCart
            {
                ProductId = id,
                UserId = 1
            };
            _context.TblCarts.Add(cartItem);
            _context.SaveChanges();

            return RedirectToAction("Index");




        }
    }
}
