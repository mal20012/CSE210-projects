using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("Mt Tembo 23", "Tegeta", "Dar es salaam", "Tanzania");
        Customer customer1 = new Customer("Vanessa Michael Urassa", address1);
        List<Product> productList1 = new List<Product>();

        Product p001 = new Product("Deodorant", "D34", 5500, 2);
        Product p002 = new Product("Toothbrush", "TB29", 2500, 1);
        Product p003 = new Product("Dettol Soap", "DS32", 3000, 3);

        productList1.Add(p001);
        productList1.Add(p002);
        productList1.Add(p003);

        Order order1 = new Order(productList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        Address address2 = new Address("Peace and Love st 435", "Salasala", "Dar es salaam", "Tanzania");
        Customer customer2 = new Customer("Cristie Chagia", address2);
        List<Product> productList2 = new List<Product>();

        Product p004 = new Product("Towel", "T004", 6700, 1);
        Product p005 = new Product("Flip flops", "FF300", 4300, 1);
        Product p006 = new Product("Face Masks", "FM980", 1200, 25);

        productList2.Add(p004);
        productList2.Add(p005);
        productList2.Add(p006);

        Order order2 = new Order(productList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        Address address3 = new Address("UN St 234", "Upanga", "Dar es salaam", "Tanzania" );
        Customer customer3 = new Customer("Jacob Temu", address3);
        List<Product> productList3 = new List<Product>();

        Product p007 = new Product("Noodles", "N90", 800, 12);
        Product p008 = new Product("Baking Flour", "B312", 5300, 1);
        Product p009 = new Product("Yoghurt", "Y22", 900, 5);

        productList3.Add(p007);
        productList3.Add(p008);
        productList3.Add(p009);

        Order order3 = new Order(productList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}