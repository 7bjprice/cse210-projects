using System;

class Program
{

    static List<Order> _orders = new();

    static void Main(string[] args)
    {
        Address address1 = new("123 Cherry Lane", "Rexburg", "ID", "United States");
        Customer customer1 = new("Bryson Price", address1);
        Order Order1 = new(customer1);
        Order1.NewProduct("TV", 1001, 500, 1);
        Order1.NewProduct("Speaker", 1002, 100, 4);
        Order1.NewProduct("Subwoofer", 1003, 200, 1);
        _orders.Add(Order1);

        Address address2 = new("456 Blackberry St", "Chehalis", "WA", "United States");
        Customer customer2 = new("Megan Price", address2);
        Order Order2 = new(customer2);
        Order2.NewProduct("iPhone", 1004, 999, 1);
        Order2.NewProduct("Shirt", 1005, 25, 3);
        Order2.NewProduct("Computer", 1006, 750, 1);
        _orders.Add(Order2);

        Address address3 = new("789 Raspberry Blvd", "Portland", "OR", "United States");
        Customer customer3 = new("Blake Price", address3);
        Order Order3 = new(customer3);
        Order3.NewProduct("Hunting Rifle", 1007, 1250, 1);
        Order3.NewProduct("2x Scope", 1008, 150, 1);
        Order3.NewProduct("8mm Round", 1009, 0.25, 32);
        _orders.Add(Order3);

        foreach (Order order in _orders)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total: {order.CalcCost():C2}");
            Console.WriteLine(new string('-', 30));
        }
    }
}