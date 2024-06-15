using System.ComponentModel;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;

public class Listing : Activity
{
    private List <string> userItems = new List<string>();

    public Listing (string activityName, string description) : base(activityName, description)
    {
    }
    public string QuestionList()
    {

        List<string> questionPrompts = new List<string>();
        questionPrompts.Add("Who are people that you appreciate?");
        questionPrompts.Add("What are personal strengths of yours?");
        questionPrompts.Add("Who are people that you have helped this week?");
        questionPrompts.Add("When have you felt the Holy Ghost this month?");
        questionPrompts.Add("Who are some of your personal heroes?");

        string randQuestion = questionPrompts[random.Next(questionPrompts.Count)];

        return randQuestion;
    }
    public void ListingExercise()
    {
        StartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {QuestionList()} --- ");
        Console.Write($"You may begin in: ");
        Countdown(5);
        Console.WriteLine();

        string item;

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(secondsDuration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            item = Console.ReadLine();

            userItems.Add(item);

        }
        Console.WriteLine();
        int itemsCount = userItems.Count();
        Console.WriteLine($"You listed {itemsCount} items!");
        EndingMessage();
    }
}