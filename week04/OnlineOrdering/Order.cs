using System;
using System.IO;
using System.Collections.Generic;
public class Order
{
    private string _customer;
    private string _name;
    private string _country;
    private List<int> _prices;
    private SortedList<string, string> _products;
    private SortedList<string, string> _order;
    public Order( string customer, string name, string country, List<int> prices, SortedList<string, string> products, SortedList<string, string> order)
    {
        _customer = customer;
        _name = name;
        _country = country;
        _prices = prices;
        _products = products;
        _order = order;
    }
    public void getPrice()
    {
        int sum = 0;
        foreach (int value in _prices)
        {
            sum = sum + value;
        }

        if (_country == "USA")
        {
            sum = sum + 5;
        }

        else
        {
            sum = sum + 35;
        }
        Console.WriteLine($"The total price of the buy will be: ${sum}");
    }
    public void packingLabel()
    {
        Console.WriteLine("The paking is:");
        List<string> orderProduct;
        string orderData = _order[_customer];
        char U = '.';
        string[] data = orderData.Split(U);
        orderProduct = data.ToList();

        string key = orderProduct[0];

        List<string> dataProduct;
        string coment = _products[key];
        string[] values = coment.Split(U);
        dataProduct = values.ToList();
        string value = dataProduct[0];
        Console.WriteLine($"First product: Name:{dataProduct[0]} ID:{orderProduct[0]}");

        key = orderProduct[2];

        coment = _products[key];
        values = coment.Split(U);
        dataProduct = values.ToList();
        value = dataProduct[0];
        Console.WriteLine($"Second product: Name:{dataProduct[0]} ID:{orderProduct[2]}");

    }
    public void shippingLabel()
    {
        Console.WriteLine("The shipping information is:");
        List<string> nameAdress;
        char U = '.';
        string[] name = _name.Split(U);
        nameAdress = name.ToList();
        foreach (string element in nameAdress)
        {
            Console.WriteLine(element);
        }
    }
}