
using System;

namespace ShoppingCartApplication
{
    public class ClothingStore : Shop
    {
        static Random random = new Random();
        public override void DisplayProducts()
        {
            Console.WriteLine("------- Clothing Store -------");
            for (int i = 0; i < 5; i++) // Display 5 random products
            {
                Product product = ProductGenerator.GenerateProduct();
                // Simulate clothing-specific details (optional)
                if (product.Category == ProductCategory.Clothing)
                {
                    string[] sizes = { "S", "M", "L", "XL" };
                    product.Name += $" (Size: {sizes[random.Next(sizes.Length)]})";
                }
                Console.WriteLine($"{i + 1}. {product.Name} - ${product.Price}");
            }
            Console.WriteLine("----------------------------");
        }

        public override Product SelectProduct(ShoppingCart cart)
        {
            Console.WriteLine("Enter product number to add to cart, or 0 to go back:");
            int choice = int.Parse(Console.ReadLine());

            if (choice > 0 && choice <= 5)
            {
                Product product = ProductGenerator.GenerateProduct(); // Simulate getting product details
                Console.WriteLine($"Selected: {product.Name} - ${product.Price}");
                cart.AddItem(product);
                return product;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                return null;
            }
        }
    }

}
