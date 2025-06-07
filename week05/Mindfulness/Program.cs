using System;
// I deceide to make a way that the program can know how many times yo do a activity, creating a file that use like count and if the file is already created, ading a new line,
// after that the StartingMessage function can cal a new function named GetCount that get the number of line in the file, geting the number of times that that actibity was doet,
// Is not necesary download the files.
class Program
{
    static void Main(string[] args)
    {
        string still = "yes";
        do
        {
            Console.WriteLine("Wealcome to Mindfulness Program, select one of the following activities:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter the number of the activity: ");
            string guess = Console.ReadLine();
            int choise = int.Parse(guess);
            Console.Clear();
            if (choise == 1)
            {
                BreathingActivity activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "BreatingCount.txt");
                activity.StartingMessage();
                activity.Display();
                activity.EndMesage();
            }

            else if (choise == 2)
            {
                ReflectingActivity activity = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "ReflectingCount.txt");
                activity.StartingMessage();
                activity.Display();
                activity.EndMesage();
            }

            else if (choise == 3)
            {
                ListingActivity activity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "ListingCount.txt");
                activity.StartingMessage();
                activity.Display();
                activity.EndMesage();
            }

            else
            {
                still = "not";
                Console.WriteLine("Tanks for use our Mindfulness Program, have a great day.");
            }
        } while (still != "not");
    }
}