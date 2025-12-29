namespace MVC_Database_Integration__Shoppers_.Models
{
    public class ProductImage:BaseModel
    {
        public string ImageURL { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
