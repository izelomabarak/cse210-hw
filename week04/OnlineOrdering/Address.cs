using System;
using System.IO;
using System.Collections.Generic;
public class Address
{
    private string _customer;
    private SortedList<string, string> _information;
    public Address(string customer, SortedList<string, string> information)
    {
        _customer = customer;
        _information = information;
    }
    public string addresMaker()
    {
        List<string> orderInformation;
        string information = _information[_customer];
        char U = '.';
        string[] data = information.Split(U);
        orderInformation = data.ToList();

        string addres = $"{orderInformation[0]},{orderInformation[1]},{orderInformation[2]},{orderInformation[3]}";

        return addres;
    }

    public string usaDetector()
    {
        List<string> orderInformation;
        string information = _information[_customer];
        char U = '.';
        string[] data = information.Split(U);
        orderInformation = data.ToList();
        string usa;

        if (orderInformation[3] == "USA")
        {
            usa = "yes";
        }
        
        else
        {
            usa = "not";
        }

        return usa;
    }
}