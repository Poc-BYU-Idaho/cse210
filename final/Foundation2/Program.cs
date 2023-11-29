using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaddress = new Address("test street name 1", "Rexburg", "Idaho", "USA");
        Address nonUsaddress = new Address("test street name 2", "Quebec City", "Quebec", "Canada");

        Customer usCustomer = new Customer("George", usaddress);
        Customer nonUsCustomer = new Customer("Jimbo", nonUsaddress);

        List<Product> usCustomerProducts = new List<Product>()
        {
            new Product("A product", "12345", 5, 2),
            new Product("Another product", "54321", 100, 1)
        };
        List<Product> nonUsCustomerProducts = new List<Product>()
        {
            new Product("A product", "12345", 5, 2),
            new Product("Another product", "54321", 100, 1),
            new Product("A third product", "99999", 20, 5)
        };

        Order usOrder = new Order(usCustomerProducts, usCustomer);
        Order nonUsOrder = new Order(nonUsCustomerProducts, nonUsCustomer);

        Console.WriteLine(usOrder.GetPackingLabel());
        Console.WriteLine($"Shipping Label: {usOrder.GetShippingLabel()}");
        Console.WriteLine($"Cost: ${usOrder.CalculateCost()}");
        Console.WriteLine("\n");
        Console.WriteLine(nonUsOrder.GetPackingLabel());
        Console.WriteLine($"Shipping Label: {nonUsOrder.GetShippingLabel()}");
        Console.WriteLine($"Cost: ${nonUsOrder.CalculateCost()}");
    }
}