namespace TechZone.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int PatrentCategoryId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
