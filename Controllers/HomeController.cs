using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Database_Integration__Shoppers_.Data;
using MVC_Database_Integration__Shoppers_.Models;
using MVC_Database_Integration__Shoppers_.ViewModels;

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
           
            Summary summary = _context.summary.FirstOrDefault();
            List<Category> categories = _context.categories.Where(c=>!c.IsDeleted).ToList();
            List<Product> products = _context.products.Where(p => !p.IsDeleted)
                .Include(p => p.category).Include(p => p.productImages.Where(pi=>!pi.IsDeleted)).ToList();
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Products=products,
                SummaryItem=summary,
                Categories=categories,
            };
            return View(homeViewModel);
        }
    }
}
