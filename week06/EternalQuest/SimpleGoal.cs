using System;
using System.IO.Enumeration;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string descripton, int points) : base(name, descripton, points)
    {
        _isComplete = false;
    }
    public override string GetDetailsString(string tipe)
    {
        string _shortName = GetName();
        string _description = GetDescription();
        int _points = GetPoints();
        return $"{tipe}.{_shortName}.{_description}.{_points}.{_isComplete}";
    }
    public string GetCompliteString(string tipe, string _shortName, string _description, string _points, string _isComplete)
    {
        return $"{tipe}.{_shortName}.{_description}.{_points}.{_isComplete}";
    }
    public override void GetRepresentationString(int num, string state)
    {
        string _shortName = GetName();
        string _description = GetDescription();
        if (state == "True")
        {
            Console.WriteLine($"{num}. [X] {_shortName} ({_description})");
        }
        else
        { 
        Console.WriteLine($"{num}. [] {_shortName} ({_description})");
        }
    }

}