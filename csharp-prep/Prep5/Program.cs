using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void Welcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string Name()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int Number()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquaredNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }

        

        static void DisplayMessage(string name, int numberSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {numberSquared}");
        }

        Welcome();
        string username = Name();
        int favNumber = Number();
        int numberSquared = SquaredNumber(favNumber);
        DisplayMessage(username,numberSquared);
    }
}