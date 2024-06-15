using System;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        static void Menu()
        {
            string choice = "0";

            bool running = true;

            while (running) 
            {
                Console.Clear();
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Start Breathing Activity ");
                Console.WriteLine("2. Start Reflecting Activity ");
                Console.WriteLine("3. Start Listing Activity ");
                Console.WriteLine("4. Quit ");

                Console.Write("Select a choice from the menu: ");

                choice = Console.ReadLine();
            if (choice == "1")
            {
                Breathing b = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                b.BreathingCycle();
            }
            else if (choice == "2")
            {
                Reflection r = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                r.Questionnaire();
            }
            else if (choice == "3")
            {
                Listing l = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                l.ListingExercise();
            }
            else if (choice == "4")
            {
                running = false;
            }
            }

        }


        Menu();
        //baseActivity.Loading();

    }
}