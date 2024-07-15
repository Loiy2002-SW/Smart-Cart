﻿

namespace ShoppingCartApplication
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            if (items.Contains(product))
            {
                items.Remove(product);
            }
            else
            {
                Console.WriteLine("Item not found in cart.");
            }
        }

        public void ViewCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }

            Console.WriteLine("------- Shopping Cart -------");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - ${item.Price} ({item.Category})");
            }
            Console.WriteLine("----------------------------");
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                totalCost += item.Price;
            }
            return totalCost;
        }
    }

}
