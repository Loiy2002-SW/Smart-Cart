using ShoppingCartApplication;

namespace ShoppingCartApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddItem_ShouldAddItemToCart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product { Name = "Test Product", Price = 10.0, Category = ProductCategory.Food };

            // Act
            cart.AddItem(product);

            // Assert
            Assert.Single(cart.items); // Verify there's one item in the cart
            Assert.Equal(product, cart.items[0]); // Verify the added item matches the expected product
        }

        [Fact]
        public void RemoveItem_ExistingItem_ShouldRemoveItemFromCart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product { Name = "Test Product", Price = 10.0, Category = ProductCategory.Food };
            cart.AddItem(product);

            // Act
            cart.RemoveItem(product);

            // Assert
            Assert.Empty(cart.items); // Verify the cart is empty after removal
        }

        [Fact]
        public void RemoveItem_NonexistentItem_ShouldNotModifyCart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product { Name = "Test Product", Price = 10.0, Category = ProductCategory.Food };

            // Act
            cart.RemoveItem(product);

            // Assert
            Assert.Empty(cart.items); // Verify the cart remains empty (no item to remove)
        }

        [Fact]
        public void CalculateTotalCost_EmptyCart_ShouldReturnZero()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();

            // Act
            double totalCost = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(0.0, totalCost); // Verify total cost is zero for an empty cart
        }

        [Fact]
        public void CalculateTotalCost_SingleItem_ShouldReturnItemPrice()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product { Name = "Test Product", Price = 15.50, Category = ProductCategory.Electronics };
            cart.AddItem(product);

            // Act
            double totalCost = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(product.Price, totalCost); // Verify total cost matches the item price
        }

        [Fact]
        public void CalculateTotalCost_MultipleItems_ShouldReturnSumOfPrices()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product { Name = "Item 1", Price = 5.99, Category = ProductCategory.Clothing };
            Product product2 = new Product { Name = "Item 2", Price = 12.75, Category = ProductCategory.Other };
            cart.AddItem(product1);
            cart.AddItem(product2);

            // Act
            double totalCost = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(product1.Price + product2.Price, totalCost); // Verify total cost is the sum of item prices
        }
    }
}