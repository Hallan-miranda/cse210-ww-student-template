using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

         var address = new Address("123 Main St", "New York", "NY", "USA");
        var customer = new Customer("Maria Souza", address);
        var order = new Order(customer);

        order.AddProduct(new Product(22, "dress", 25.0, 2));
        order.AddProduct(new Product( 21, "shirt", 40.0, 1));

        Console.WriteLine(customer.GetCustomer());
        Console.WriteLine($"Products Price: ${order.GetproductPrice()}");
        Console.WriteLine($"Shipping Pricce: ${order.GetTax()}");
        Console.WriteLine($"Total: ${order.GetTotalPrice():0.00}");

        var address2 = new Address("456 Elm Street", "Los Angeles", "CA", "BR");
        var customer2 = new Customer("John Miller", address2);
        var order2 = new Order(customer2);

        order2.AddProduct(new Product(31, "jeans", 55.0, 1));
        order2.AddProduct(new Product(45, "jacket", 120.0, 1));
        order2.AddProduct(new Product(12, "hat", 20.0, 3));

        Console.WriteLine(customer2.GetCustomer());
        Console.WriteLine($"Products Price: ${order2.GetproductPrice()}");
        Console.WriteLine($"Shipping Price: ${order2.GetTax()}");
        Console.WriteLine($"Total: ${order2.GetTotalPrice():0.00}");

        

    }
}