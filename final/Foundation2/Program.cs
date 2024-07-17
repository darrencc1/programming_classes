using System;
// I learned about decimal type and used it in this program, its supposed to be better for financial caluclations 
// It also aparently is better with rounding, I read that but did not look into how it is better. 
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("175 Main St", "Warrenton", "VA", "USA");
        Customer customer1 = new Customer("Anthony Star", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Pot", "p113", 9.87m, 5));
        order1.AddProduct(new Product("Golden Fork", "F77", 75.16m, 2));

        Address address2 = new Address("16 La Saint", "Abitibi", "Quebec", "Canada");
        Customer customer2 = new Customer("Michael Chambers", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Washer", "W1", .55m, 100));
        order2.AddProduct(new Product("Bolt", "B82", 1.2m, 100));

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: {order1.TotalCost():C}\n");

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: {order2.TotalCost():C}");
    }
}