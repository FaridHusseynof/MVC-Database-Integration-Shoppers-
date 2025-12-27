namespace MVC_Database_Integration__Shoppers_.Models
{
    public class Product:BaseModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
       
    }
}
