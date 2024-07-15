# Smart Cart Application

This project is a C# console application that simulates a smart shopping cart. It includes various functionalities for managing products, shopping cart operations, product generation, and store interactions.

## Table of Contents
1. [Classes](#classes)
    - [Product.cs](#productcs)
    - [ShoppingCart.cs](#shoppingcartcs)
    - [ProductGenerator.cs](#productgeneratorcs)
    - [Shop Classes](#shop-classes)
2. [Program.cs](#programcs)
3. [Unit Tests](#unit-tests)
4. [Stretch Goals](#stretch-goals)
5. [Grading Structure](#grading-structure)
6. [Running the Application](#running-the-application)

## Classes

### Product.cs

Defines a `Product` class with properties such as `Name`, `Price`, and `Category`. The `ProductCategory` enum includes various categories like Food, Clothing, Electronics, and Others.

### ShoppingCart.cs

Manages the shopping cart, including functionalities to add and remove items, view the cart's contents, and calculate the total cost of items in the cart.

### ProductGenerator.cs

Generates random products with randomized names, prices, and categories. This helps simulate different products available in stores.

### Shop Classes

Includes classes for different types of stores, such as `GroceryStore` and `ClothingStore`. Each store class displays available products and allows users to select products to add to their shopping cart.

## Program.cs

The main entry point of the application. It provides a console-based user interface with a menu that allows users to visit different stores, view their shopping cart, and calculate the total cost of items. The application runs in a loop until the user decides to exit.

## Unit Tests

Includes unit tests to verify functionalities such as adding and removing items from the cart and calculating the total cost in different scenarios.

## Stretch Goals

- Implement discounts or promotions.
- Modify the `Product` class to include a discount property.
- Update the total cost calculation to consider discounts on specific products or combinations.

## Grading Structure

Points are assigned based on the completion of each component. Focus on the functionalities mentioned for each class and implement unit tests to ensure proper behavior.

## Running the Application

To run the application, compile and execute the `Program.cs` file. Use the console-based menu to navigate through different options, visit shops, view the cart, and calculate the total cost.
