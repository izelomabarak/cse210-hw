using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {               
        string response = "A";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int yourGuessInt  = -1;
            int tries = 0;
            do
            {
                Console.Write("What is your guess? ");
                string yourGuess = Console.ReadLine();
                yourGuessInt = int.Parse(yourGuess);

                if (magicNumber == yourGuessInt)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (magicNumber > yourGuessInt)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < yourGuessInt)
                {
                    Console.WriteLine("Lower");
                }
                tries++;
            }while (magicNumber != yourGuessInt);
            Console.WriteLine($"You do {tries} guesses");

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }while (response == "yes");
    }
}