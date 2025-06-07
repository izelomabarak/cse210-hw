using System;

public class Activity
{
    private string _name;
    private string _descripton;
    private int _duration;
    private string _fileNameOpen;
    public Activity(string name, string descripton, string fileNameOpen)
    {
        _name = name;
        _descripton = descripton;
        _fileNameOpen = fileNameOpen;
    }

    public int GetCount()
    {
        int count = 0;
        if (File.Exists(_fileNameOpen))
        {
            string[] lines = System.IO.File.ReadAllLines(_fileNameOpen);
            List<string> times = new List<string>();
            times = lines.ToList();
            count = times.Count;
        }
        else
        {
            using (FileStream fs = File.Create("BreathingCount.txt")) { }
        }
        return count;
    }
    public void StartingMessage()
    {
        int numberTimes = GetCount();
        Console.WriteLine($"The activitie is {_name}, you all ready do this activitie {numberTimes} times:");
        Console.WriteLine(" ");
        Console.WriteLine(_descripton);
        Console.WriteLine(" ");
        Console.Write("Set the duration of the activity in secons: ");
        string seconsInput = Console.ReadLine();
        int secons = int.Parse(seconsInput);
        _duration = secons;
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(5);
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetFileName()
    {
        return _fileNameOpen;
    }
    public void Animation(int duration)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void EndMesage()
    {
        Console.WriteLine("Good Job!");
        Animation(5);
        Console.WriteLine($"You complete the {_name} in {_duration} secons, well done");
        Animation(5);
        Console.Clear();
    }
}
