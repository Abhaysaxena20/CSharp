namespace WebApplication3.Models
{
    public class MergeModel
    {
        public List<Category> category { get; set; }
        public List<Products> products { get; set; }
    }
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Category {  get; set; }

    }
}
