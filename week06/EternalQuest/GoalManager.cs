using System;
using System.IO.Enumeration;
using System.Net;

public class GoalManager
{
    private List<string> _goals = new List<string>();
    private int _score = 0;
    public List<string> GetGoals()
    {
        return _goals;
    }
    public int GetScore()
    {
        return _score;
    }
    public int DisplayStart(string score)
    {
        if (int.Parse(score) < 1000)
        {
            Console.WriteLine($"You have {score} points, you are in the rank of Squire.");
        }
        else if (int.Parse(score) > 1000 && int.Parse(score) < 2000)
        {
            Console.WriteLine($"You have {score} points, you are in the rank of Knight.");
        }
        else if (int.Parse(score) > 2000 && int.Parse(score) < 3000)
        {
            Console.WriteLine($"You have {score} points, you are in the rank of Chaplain.");
        }
        else if (int.Parse(score) > 3000 && int.Parse(score) < 4000)
        {
            Console.WriteLine($"You have {score} points, you are in the rank of Paladin.");
        }
        else if (int.Parse(score) > 4000 && int.Parse(score) < 5000)
        {
            Console.WriteLine($"You have {score} points, you are in the rank of Grand Master.");
        }
        Console.WriteLine($"You have {score} points.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Evend");
        Console.WriteLine("  6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string guess = Console.ReadLine();
        int choise = int.Parse(guess);
        return choise;
    }
    public int CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Sinple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string respond = Console.ReadLine();
        int selection = int.Parse(respond);
        return selection;
    }
    public void SaveGoals(List<string> goals)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string line in goals)
            {
                outputFile.WriteLine(line);
            }
        }
    }
    public List<string> LoadGoals()
    {
        List<string> goals = new List<string>();
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            goals.Add(line);
        }
        return goals;
    }
    public bool Quit()
    {
        return true;
    }
}
