using System;
using System.IO.Enumeration;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _times;
    private int _bonus;
    public ChecklistGoal(string name, string descripton, int points, int target, int times) : base(name, descripton, points)
    {
        _times = times;
        _target = target;
    }
    public override void GetRepresentationString(int num, string state)
    {
        string _shortName = GetName();
        string _description = GetDescription();
        if (state == "True")
        {
            Console.WriteLine($"{num}. [X] {_shortName} ({_description}) --Currently complete: {_times}/{_target}");
        }
        else
        { 
            Console.WriteLine($"{num}. [] {_shortName} ({_description}) --Currently complete: {_times}/{_target}");
        }
    }
    public override string GetDetailsString(string tipe)
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string targetString = Console.ReadLine();
        _target = int.Parse(targetString);
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        string bonusString = Console.ReadLine();
        _bonus = int.Parse(bonusString);
        string _shortName = GetName();
        string _description = GetDescription();
        _amountCompleted = GetPoints();
        return $"{tipe}.{_shortName}.{_description}.{_amountCompleted}.{_bonus}.{_target}.{_times}";
    }
    public string GetCompliteString(string tipe, string shortName, string description, string amountCompleted, string bonus, string target, string times)
    {
        return $"{tipe}.{shortName}.{description}.{amountCompleted}.{bonus}.{target}.{times}";
    }
}