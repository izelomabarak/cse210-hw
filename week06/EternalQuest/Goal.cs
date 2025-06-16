using System;
using System.IO.Enumeration;

public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string descripton, int points)
    {
        _shortName = name;
        _description = descripton;
        _points = points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool IsComplete()
    {
        return true;
    }
    public virtual string GetDetailsString(string tipe)
    {
        return $"{tipe}.{_shortName}.{_description}.{_points}";
    }
    public virtual void GetRepresentationString(int num, string state)
    {
        Console.WriteLine($"{num}. [] {_shortName} ({_description})");
    }

    public void GetSareString(int num)
    {
        Console.WriteLine($"{num}. {_shortName}");
    }
    
}
