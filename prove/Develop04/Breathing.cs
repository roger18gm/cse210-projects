using System.Reflection.PortableExecutable;

public class Breathing : Activity
{
    public Breathing(string activityName, string description) : base(activityName, description)
    {

    }
    public void BreathingCycle()
    {
        StartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(secondsDuration); 
        int breatheTime = 3;
        while(DateTime.Now < futureTime)
        {   
            Console.Write("Breathe in...");
            Countdown(breatheTime);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            Countdown(breatheTime);
            Console.WriteLine();
            Console.WriteLine();
            
            //Thread.Sleep(1000);
            breatheTime++;
            
        }
        EndingMessage();
    }

}