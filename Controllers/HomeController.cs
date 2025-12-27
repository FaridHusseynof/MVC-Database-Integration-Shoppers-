using Microsoft.AspNetCore.Mvc;
using MVC_Database_Integration__Shoppers_.Data;
using MVC_Database_Integration__Shoppers_.Models;

namespace MVC_Database_Integration__Shoppers_.Controllers
{
    public class HomeController : Controller
    {
        private ShoppersDbContext _context {get;}
        public HomeController(ShoppersDbContext context)
        {
            _context=context;    
        }
        public IActionResult Index()
        {
            List<Product> products = _context.products.ToList();
            return View(products);
        }
    }
}
