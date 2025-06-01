using System;
using System.IO;
using System.Collections.Generic;
public class Product
{
    private string _customer;
    private SortedList<string, string> _products;
    private SortedList<string, string> _order;
    public Product(string customer, SortedList<string, string> products, SortedList<string, string> order)
    {
        _customer = customer;
        _products = products;
        _order = order;
    }
    public List<int> products()
    {
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
        int value = int.Parse(dataProduct[1]) * int.Parse(orderProduct[1]);
        List<int> prices = new List<int>();
        prices.Add(value);

        key = orderProduct[2];

        coment = _products[key];
        values = coment.Split(U);
        dataProduct = values.ToList();
        value = int.Parse(dataProduct[1]) * int.Parse(orderProduct[3]);
        prices.Add(value);
        return prices;
    }
}