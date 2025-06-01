using System;

class Program
{
    static void Main(string[] args)
    {
                static void Main()
        {
            SortedList<string, string> information = new SortedList<string, string>();
            SortedList<string, string> order = new SortedList<string, string>();
            SortedList<string, string> products = new SortedList<string, string>();
            order.Add("Ian Ixehuatl", "M4.2.A5.4");
            order.Add("Maria Martines", "B5.6.L7.3");
            products.Add("A5", "Apple.5");
            products.Add("M4", "Meat.25");
            products.Add("B5", "Bread.10");
            products.Add("L7", "Lettuce.8");
            information.Add("Ian Ixehuatl", "3860 NW 125th St.New York.New York.USA");
            information.Add("Maria Martines", "3790 NW 456th St.Ecatepec.Estado de Mexico.Mexico");

            Console.WriteLine("First Order");
            Console.WriteLine(" ");

            Product product1 = new Product("Ian Ixehuatl", products, order);
            List<int> prices = product1.products();

            Address address1 = new Address("Ian Ixehuatl", information);
            string address = address1.addresMaker();
            string usa = address1.usaDetector();

            Customer customer1 = new Customer("Ian Ixehuatl", address, usa);
            string name = customer1.nameAddress();
            string country = customer1.knowCountry();

            Order order1 = new Order("Ian Ixehuatl", name, country, prices, products, order);
            order1.getPrice();
            Console.WriteLine(" ");
            order1.packingLabel();
            Console.WriteLine(" ");
            order1.shippingLabel();
            Console.WriteLine(" ");

            Console.WriteLine("Second Order");
            Console.WriteLine(" ");

            Product product2 = new Product("Maria Martines", products, order);
            prices = product2.products();

            Address address2 = new Address("Maria Martines", information);
            address = address2.addresMaker();
            usa = address2.usaDetector();

            Customer customer2 = new Customer("Maria Martines", address, usa);
            name = customer2.nameAddress();
            country = customer2.knowCountry();

            Order order2 = new Order("Maria Martines", name, country, prices, products, order);
            order2.getPrice();
            Console.WriteLine(" ");
            order2.packingLabel();
            Console.WriteLine(" ");
            order2.shippingLabel();
            Console.WriteLine(" ");

        }
        Main();
    }
}