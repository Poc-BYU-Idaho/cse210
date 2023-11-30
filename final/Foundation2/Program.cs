using System;

class Program
{
    static void Main(string[] args)
    {
        Order usOrder = new Order(new List<Product>(){new Product("A product", "12345", 5, 2), new Product("Another product", "54321", 100, 1)}, new Customer("George", new Address("test street name 1", "Rexburg", "Idaho", "USA")));

        Order nonUsOrder = new Order(new List<Product>(){new Product("A product", "12345", 5, 2), new Product("Another product", "54321", 100, 1), new Product("A third product", "99999", 20, 5)}, new Customer("Jimbo", new Address("test street name 2", "Quebec City", "Quebec", "Canada")));

        Console.WriteLine(usOrder.GetPackingLabel());
        Console.WriteLine($"Shipping Label: {usOrder.GetShippingLabel()}");
        Console.WriteLine($"Cost: ${usOrder.CalculateCost()}");
        Console.WriteLine("\n");
        Console.WriteLine(nonUsOrder.GetPackingLabel());
        Console.WriteLine($"Shipping Label: {nonUsOrder.GetShippingLabel()}");
        Console.WriteLine($"Cost: ${nonUsOrder.CalculateCost()}");
    }
}