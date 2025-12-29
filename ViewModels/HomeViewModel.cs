using MVC_Database_Integration__Shoppers_.Models;

namespace MVC_Database_Integration__Shoppers_.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public Summary SummaryItem { get; set; }
        public List<Category> Categories { get; set; }
    }
}
