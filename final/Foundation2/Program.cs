using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample data for Address and Customer
            var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            var customer1 = new Customer("John Doe", address1);

            var address2 = new Address("456 Elm Rd", "Toronto", "ON", "Canada");
            var customer2 = new Customer("Jane Smith", address2);

            // Sample products
            var productsOrder1 = new List<Product>
            {
                new Product("Widget", "W123", 2.50, 4),
                new Product("Gadget", "G456", 5.75, 2)
            };

            var productsOrder2 = new List<Product>
            {
                new Product("Thingamajig", "T789", 10.00, 1),
                new Product("Doohickey", "D012", 3.25, 5)
            };

            // Create orders
            var order1 = new Order(productsOrder1, customer1);
            var order2 = new Order(productsOrder2, customer2);

            // Display results for Order 1
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():0.00}");
            Console.WriteLine(new string('-', 30));

            // Display results for Order 2
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():0.00}");
        }
    }
}
