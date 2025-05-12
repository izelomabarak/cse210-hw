using System;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int numberSquare = SquareNumber(number);
            DisplayResult(name, numberSquare);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favoriteNumber = Console.ReadLine();
            int number = int.Parse(favoriteNumber);
            return number;
        }

        static int SquareNumber(int number)
        {
            int numberSquare = number * number;
            return numberSquare;
        }

        static void DisplayResult(string name, int numberSquare)
        {
            Console.WriteLine($"{name}, the square of your number is {numberSquare}");
        }
        Main();
    }
}