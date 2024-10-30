using System;

namespace OnlineOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            var address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
            var address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");

            // Create customers
            var customer1 = new Customer("John Doe", address1);
            var customer2 = new Customer("Jane Smith", address2);

            // Create products
            var product1 = new Product("Laptop", "LAP123", 799.99m, 1);
            var product2 = new Product("Mouse", "MOU456", 19.99m, 2);
            var product3 = new Product("Keyboard", "KEY789", 49.99m, 1);

            // Create orders
            var order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            var order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display order information
            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.TotalCost():0.00}");
            Console.WriteLine();

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.TotalCost():0.00}");
        }
    }
}