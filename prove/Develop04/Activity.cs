public class Activity
{
    private string activityName;

    private string description;

    protected int secondsDuration;

    protected Random random;

    // protected DateTime startTime;
    // protected DateTime endTime;

    public Activity(string activityName, string description)
    {
        this.activityName = activityName;
        this.description = description;
        random = new Random();
        // startTime = DateTime.Now;
        // endTime = startTime.AddSeconds(secondsDuration);
        //this.secondsDuration = secondsDuration;
    }

    public int StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {this.activityName} Activity!");
        Console.WriteLine();
        Console.WriteLine(this.description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        this.secondsDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready!");
        Loading();
        Console.Clear();
        Console.WriteLine("Get Ready!");
        Console.WriteLine();

        return this.secondsDuration;
    }

    public void EndingMessage()
    {
        Console.WriteLine("Activity Completed!");
        Loading();
        Console.WriteLine($"You have completed {this.secondsDuration} seconds of the {this.activityName} activity.");
        Thread.Sleep(5000);
    }

    public void Loading() // add parameter for seconds
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach(string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

     public int GetSecondsDurations()
    {
        return this.secondsDuration;
    }
}
