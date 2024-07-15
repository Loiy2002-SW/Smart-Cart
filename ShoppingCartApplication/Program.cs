namespace ShoppingCartApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            List<Shop> shops = new List<Shop>() { new GroceryStore(), new ClothingStore() }; 
            int choice;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("------- Smart Cart --------");
                Console.WriteLine("1. Visit Grocery Store");
                Console.WriteLine("2. Visit Clothing Store");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Remove Item from Cart");  
                Console.WriteLine("6. Exit");
                Console.WriteLine("----------------------------");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        shops[choice - 1].DisplayProducts();
                        Product selectedProductFromGroceryStore = shops[choice - 1].SelectProduct(cart);
                        if (selectedProductFromGroceryStore != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Item added to cart!");
                        }
                        break;
                    case 2:
                        shops[choice - 1].DisplayProducts();
                        Product selectedProductFromClothingStore = shops[choice - 1].SelectProduct(cart);
                        if (selectedProductFromClothingStore != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Item added to cart!");
                        }
                        break;
                    case 3:
                        cart.ViewCart();
                        break;
                    case 4:
                        double totalCost = cart.CalculateTotalCost();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Total Cost: ${totalCost}");
                        break;
                    case 5:
                        cart.ViewCart();
                        if (cart.items.Count > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Enter item number to remove (or 0 to go back):");
                            int removeChoice = int.Parse(Console.ReadLine());
                            if (removeChoice > 0 && removeChoice <= cart.items.Count)
                            {
                                cart.RemoveItem(cart.items[removeChoice - 1]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Item removed from cart.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid selection.");
                            }
                        }
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Exiting Smart Cart...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 6);
        }
    }

}
