using System;
public class Job
{
    public string _company;
    public string _jopTitle;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"{_jopTitle} ({_company}) {_startYear}-{_endYear}");
    }
}