

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
        private static Random random = new Random();

        public static Product GenerateProduct()
        {
            string[] names = { "Bread", "Shirt", "Headphones", "Book", "Water Bottle" };
            ProductCategory[] categories = { ProductCategory.Food, ProductCategory.Clothing, ProductCategory.Electronics, ProductCategory.Other, ProductCategory.Other };

            string name = names[random.Next(names.Length)];
            double price = Math.Round(random.NextDouble() * 100, 2); // Generate random price between 0 and 100 with 2 decimals
            ProductCategory category = categories[random.Next(categories.Length)];

            return new Product { Name = name, Price = price, Category = category };
        }
    }

}
