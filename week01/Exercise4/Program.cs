using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float numberNew = 0;
        float sumNumber = 0;
        float largest = 0;
        float smallest = 0;
        do
        {
            Console.Write("What is your guess? ");
            string numberWrite = Console.ReadLine();
            numberNew = int.Parse(numberWrite);
            if (numberNew != 0)
            {
                numbers.Add(numberNew);
            }
        } while (numberNew != 0);
        foreach (float number in numbers)
        {
            sumNumber = sumNumber + number;
            if (number > largest)
            {
                largest = number;
            }
            if (largest > number)
            {
                smallest = number;
            }
        }    
        foreach (float number in numbers)
        {
            if (smallest > number)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The sum is: {sumNumber}");
        float sizeList = numbers.Count;
        float average = sumNumber / sizeList;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The largest number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (float number in numbers)
        {
            Console.WriteLine(number);            
        }
    }
}