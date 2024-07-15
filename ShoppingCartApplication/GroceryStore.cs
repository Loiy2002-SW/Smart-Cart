

namespace ShoppingCartApplication
{
    public class GroceryStore : Shop
    {
        public override void DisplayProducts()
        {
            Console.WriteLine("------- Grocery Store -------");
            for (int i = 0; i < 5; i++) // Display 5 random products
            {
                Product product = ProductGenerator.GenerateProduct();
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

    public abstract class Shop
    {
        public abstract void DisplayProducts();
        public abstract Product SelectProduct(ShoppingCart cart);
    }

}
