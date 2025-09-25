using System;

class Program
{
    static void Main(string[] args)
    {
        // The customers
        Customer customer1 = new Customer("Alice Johnson", new Address("123 Main St", "Los Angeles", "Texas", "United States"));
        Customer customer2 = new Customer("Bob Smith", new Address("789 King St", "Toronto", "Alberta", "Canada"));

        // Orders with their customer and customer's chosen products
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP1001", 899.99, 1));
        order1.AddProduct(new Product("USB Cable", "USB2002", 9.99, 3));
        // <->
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MON3003", 199.99, 2));
        order2.AddProduct(new Product("Keyboard", "KEY4004", 49.99, 1));
        order2.AddProduct(new Product("Mouse", "MOU5005", 29.99, 1));

        // Display orders
        Console.Clear();
        // <->
        Console.WriteLine("<-- Order 1 -->");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalOrderCost():0.00}\n");
        // <->
        Console.WriteLine("<-- Order 2 -->");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalOrderCost():0.00}");
    }
}