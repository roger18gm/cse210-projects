using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Please enter your grade percentage: ");
        string percent = Console.ReadLine();
        int gradeNumber = int.Parse(percent);
        string gradeLetter;

        if (gradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        
        int gradeSign = gradeNumber % 10;
        string sign;

        if (gradeSign >=7)
        {
            sign = "+";
        }
        else if (gradeSign <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (gradeNumber >= 94 && gradeNumber <= 60)
        {
            Console.WriteLine($"Final grade: {gradeLetter}");
        }    
        else  
        {  
            Console.WriteLine($"Final grade: {gradeLetter}{sign}");
        }
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations you have passed the course!");
        }
        else
        {
            Console.WriteLine("Yikes! You did not pass the course, please try again next semester.");
        }
    }
}