namespace WebApplication3.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int categoryId { get; set; }
        public Category category { get; set; }
        public string Image { get; set; }
       // public virtual Category Category { get; set; }
    }
}
