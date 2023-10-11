using Microsoft.AspNetCore.Mvc;
using mini_project_core6.Data;

namespace mini_project_core6.Controllers
{
    public class CartController : Controller
    {
        private readonly db_miniprojectContext _context;

        public CartController(db_miniprojectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.TblProducts.OrderByDescending(x => x.PId).ToList());
        }
        public IActionResult add_to_cart(int id)
        {
            var pro = _context.TblProducts.Where(x => x.PId == id).FirstOrDefault();
            return View(pro);
        }
    }
}
