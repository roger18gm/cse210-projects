using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Entry newEntry = new Entry();
        Journal newJournal = new Journal();

        newJournal.MenuPrompt();

    }
}