using System;

public class ReflectingActivity : Activity
{
    private List<string> _promps;
    private List<string> _questions;
    public ReflectingActivity(string name, string descripton, string fileNameOpen) : base(name, descripton, fileNameOpen)
    {
        List<string> promps = new List<string>();
        promps.Add("Think of a time when you stood up for someone else.");
        promps.Add("Think of a time when you did something really difficult.");
        promps.Add("Think of a time when you helped someone in need.");
        promps.Add("Think of a time when you did something truly selfless.");
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        _promps = promps;
        _questions = questions;
    }
    public string RandomPromps()
    {
        Random random = new Random();
        int randomNumber = random.Next(4);
        string randomPromps = _promps[randomNumber];
        return randomPromps;
    }
    public string RandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(9);
        string randomQuestion = _questions[randomNumber];
        return randomQuestion;
    }
    public void Display()
    {
        string fileName = GetFileName();
        File.AppendAllText(fileName, "1" + Environment.NewLine);
        Console.WriteLine("Consider the following promt:");
        Console.WriteLine(" ");
        Console.WriteLine($"--- {RandomPromps()} ---");
        Console.WriteLine(" ");
        Console.WriteLine("Whem you have somenting in mind, press enter to continue.");
        string guess = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"{RandomQuestion()} ");
            Animation(10);
            Console.WriteLine(" ");
        }
    }
}
