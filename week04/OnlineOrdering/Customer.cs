using System;
using System.IO;
using System.Collections.Generic;
public class Customer
{
    private string _customer;
    private string _address;
    private string _country;
    public Customer(string customer, string address, string country)
    {
        _customer = customer;
        _address = address;
        _country = country;
    }
    public string nameAddress()
    {
        return $"Name:{_customer}.Address:{_address}";
    }
    public string knowCountry()
    {
        string country;
        if (_country == "yes")
        {
            country = "USA";
        }

        else
        {
            country = "not USA";
        }

        return country;
    }

}