namespace MVC_Database_Integration__Shoppers_.Models
{
    public class Category:BaseModel
    {
        public string Name { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
