using System;
using System.IO.Enumeration;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string descripton, string fileNameOpen) : base(name, descripton, fileNameOpen){}

    public void Display()
    {
        string fileName = GetFileName();
        File.AppendAllText(fileName, "1" + Environment.NewLine);
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine(" ");
            Console.Write("Now breathe out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
