using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _questions;
    public ListingActivity(string name, string descripton, string fileNameOpen) : base(name, descripton, fileNameOpen)
    {
        List<string> questions = new List<string>();
        questions.Add("Who are people that you appreciate?");
        questions.Add("What are personal strengths of yours?");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");
        questions.Add("Who are some of your personal heroes?");
        _questions = questions;
    }
    public string RandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(5);
        string randomQuestion = _questions[randomNumber];
        return randomQuestion;
    }
    public void Display()
    {
        string fileName = GetFileName();
        File.AppendAllText(fileName, "1" + Environment.NewLine);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {RandomQuestion()} ---");
        Console.WriteLine("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        List<string> answers = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            answers.Add(answer);
        }
        _count = answers.Count;
        Console.WriteLine($"You listed {_count} answers!");
        Console.WriteLine(" ");
    }
}
