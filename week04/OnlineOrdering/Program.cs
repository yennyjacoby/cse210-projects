using System;

class Program
{
    static void Main(string[] args)
    {
        //COSTUMER 1

        Address address1 = new Address(
            "197 red diamond street",
            "Cedar City",
            "Utah",
            "USA"
        );

        Customer customer1 = new Customer("Peter Jones", address1);

        Product product1= new Product("silver spoon", "G001", 50, 5);
        Product product2= new Product("Golden plates", "G021", 200, 1);
        Product product3= new Product("Brown cups", "G052", 80, 4);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("\nORDER 1 - INFORMATION");

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());        


        //COSTUMER 2
        Address address2 = new Address(
            "80 Main Street",
            "Villavicencio",
            "Meta",
            "Colombia"
        );

        Customer customer2 = new Customer("Sandy Millers", address2);

        Product product4= new Product("Red Carpet", "K201", 100, 1);
        Product product5= new Product("Yellow purse", "M532", 30, 2);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("\nORDER 2 - INFORMATION");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());        

    }
}