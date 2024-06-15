using System;
using System.Collections.Generic;
public class Reflection : Activity
{
    public Reflection(string activityName, string description) : base(activityName, description)
    {

    }
    public string PonderList()
    {
        List<string> ponderPrompts = new List<string>();
        ponderPrompts.Add("Think of a time when you stood up for someone else.");
        ponderPrompts.Add("Think of a time when you did something really difficult.");
        ponderPrompts.Add("Think of a time when you helped someone in need.");
        ponderPrompts.Add("Think of a time when you did something truly selfless.");

        string randPonder = ponderPrompts[random.Next(ponderPrompts.Count)];

        return randPonder;
    }

    public string QuestionList()
    {

        List<string> questionPrompts = new List<string>();
        questionPrompts.Add("Why was this experience meaningful to you?");
        questionPrompts.Add("Have you ever done anything like this before?");
        questionPrompts.Add("How did you get started?");
        questionPrompts.Add("How did you feel when it was complete?");
        questionPrompts.Add("What made this time different than other times when you were not as successful?");
        questionPrompts.Add("What is your favorite thing about this experience?");
        questionPrompts.Add("What could you learn from this experience that applies to other situations?");
        questionPrompts.Add("What did you learn about yourself through this experience?");
        questionPrompts.Add("How can you keep this experience in mind in the future?");

        string randQuestion = questionPrompts[random.Next(questionPrompts.Count)];

        return randQuestion;
    }
    public void Questionnaire()
    {
        StartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {PonderList()} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(30);
        Console.Write($"> {QuestionList()} ");
        Loading();
        Console.WriteLine(); 
        DateTime questionTimer = currentTime.AddSeconds(10);

        while (DateTime.Now < futureTime)
        {
            if (DateTime.Now >= questionTimer)
            {
                Console.Write($"> {QuestionList()} ");
                Loading();
                Console.WriteLine(); 
                questionTimer = questionTimer.AddSeconds(10);
            }
        }
        EndingMessage();
    }

}