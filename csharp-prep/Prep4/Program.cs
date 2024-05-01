using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 99999999;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine()); 
            numbers.Add(number);

        }
        
        int sum = 0;
        float average = 0;
        int max = -1;

        foreach (int listNumber in numbers)
        {
            sum += listNumber;

            average = ((float)sum) / (numbers.Count - 1);

            if (listNumber > max)
            {
                max = listNumber;
            }
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");

    }
}