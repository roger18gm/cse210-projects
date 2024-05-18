using System;
using System.Collections.Generic;
using System.Runtime;
using System.IO;
using System.Reflection.Metadata;

public class Entry
{
   
    Random randomGenerator = new Random();
    string response;
    string randomPrompt;
    public string fileName = "defaultFile.txt";
    DateTime theCurrentTime = DateTime.Now;
    
    public List<string> _promptList = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was one thing that you learned today?",
        "What do I want to do tomorrow to reach my goals?",
        "What do I need to get done tomorrow?",
        "What was the funniest thing that happened today?",
        "What song did I feel the most throughout the day?",
        "Why was today so great?"
    };

    public void DisplayMenuPrompt()
    {
        int randomIndex = randomGenerator.Next(_promptList.Count);
        randomPrompt = _promptList[randomIndex];
        Console.WriteLine(randomPrompt);
        response = Console.ReadLine();
    }

    public void WriteEntry(bool journalLoaded, string loadedTextFile)
    {
        if (journalLoaded)
        {
            using (StreamWriter outputFile = new StreamWriter(loadedTextFile, true))
            {
                string dateText = theCurrentTime.ToShortDateString();

                outputFile.WriteLine($"Date: {dateText} - Prompt: {randomPrompt}");
                outputFile.WriteLine($"{response}");
                outputFile.WriteLine();
            }
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                string dateText = theCurrentTime.ToShortDateString();

                outputFile.WriteLine($"Date: {dateText} - Prompt: {randomPrompt}");
                outputFile.WriteLine($"{response}");
                outputFile.WriteLine();
            }
        }
    }

    public void DisplayEntry(bool journalLoaded, string loadedTextFile)
    {
        if (journalLoaded)
        {
            string[] lines = System.IO.File.ReadAllLines(loadedTextFile);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        } 
        else
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}