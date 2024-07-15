

namespace ShoppingCartApplication
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }
    }

    public enum ProductCategory
    {
        Food,
        Clothing,
        Electronics,
        Other
    }
}
