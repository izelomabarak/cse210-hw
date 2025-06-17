using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> activitys = new List<string>();
        activitys.Add("Running,30 Aug 2024,30,7.8");
        activitys.Add("Cycling,24 Oct 2024,80,8.9");
        activitys.Add("Swimming,02 Dec 2024,10,5.5");
        activitys.Add("Running,26 Jan 2022,120,16.4");
        activitys.Add("Cycling,17 Apr 2022,50,6.3");
        activitys.Add("Swimming,11 Jun 2022,100,55");
        foreach (string activity in activitys)
        {
            List<string> activityData;
            string sample = activity;
            char U = ',';
            string[] data = sample.Split(U);
            activityData = data.ToList();
            if (activityData[0] == "Running")
            {
                Running running = new Running(activityData[0], activityData[1], double.Parse(activityData[2]), double.Parse(activityData[3]));
                Console.WriteLine(running.GetSummary());
            }

            else if (activityData[0] == "Cycling")
            {
                Cycling cycling = new Cycling(activityData[0], activityData[1], double.Parse(activityData[2]), double.Parse(activityData[3]));
                Console.WriteLine(cycling.GetSummary());
            }

            else if (activityData[0] == "Swimming")
            {
                Swimming swimming = new Swimming(activityData[0], activityData[1], double.Parse(activityData[2]), double.Parse(activityData[3]));
                Console.WriteLine(swimming.GetSummary());
            }
        }
    }
}