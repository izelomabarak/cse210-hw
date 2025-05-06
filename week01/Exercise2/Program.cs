using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercentage);
        int gradeLastDigit = gradeNumber % 10;
        string letterGrade = "";
        string message = "";
        string letterSign  = "";
        if (gradeNumber >= 90)
        {
            letterGrade = "A";
        }

        else if (gradeNumber >= 80)
        {
            letterGrade = "B";
        }

        else if (gradeNumber >= 70)
        {
            letterGrade = "C";
        }

        else if (gradeNumber >= 60)
        {
            letterGrade = "D";
        }

        else if (gradeNumber < 60)
        {
            letterGrade = "F";
        }

        if (gradeNumber >= 70)
        {
            message = "Great Jop, You Pass, Kep Foward";
        }
        
        if (gradeNumber < 70)
        {
            message = "O Your Score is To Low to Pas, You Need Improve and I Now That You Can Improve, Kep Foward";
        }

        if (gradeLastDigit >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            letterSign = "+";
        }

        if (gradeLastDigit < 3 && letterGrade != "F" && gradeNumber != 100)
        {
            letterSign = "-";
        }

        Console.WriteLine($"Your grade is {letterGrade}{letterSign}");
        Console.WriteLine($"{message}");
    }
}