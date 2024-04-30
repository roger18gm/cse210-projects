using System;

class Program
{
    static void Main(string[] args)
    {
        
        string response = "yes";
        
        while (response.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int count = 0;
        
            Console.WriteLine("Guess the magic number!");
            while (guess != magicNumber)
            { 
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                count ++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("You got it!");
                
                }
                
            } 

            Console.WriteLine($"Total attempts: {count}");
            Console.Write("Would you like to play again? (yes/no) ");
            response = Console.ReadLine();
            
        }

        Console.WriteLine("Have a good day!");
        
    }
}