public abstract class Goal
{
    private string goalDesc;
    private string goalName;
    private int goalPoints;

    public Goal(string goalName, string goalDesc, int goalPoints)
    {
        this.goalName = goalName;
        this.goalDesc = goalDesc;
        this.goalPoints = goalPoints;
    }


    public abstract string RecordEvent();
    public abstract bool IsComplete();

    // public virtual void GoalCreation()
    // {
    //     Console.WriteLine("What is the name of the goal? ");
    //     goalName = Console.ReadLine();
    //     Console.WriteLine();
    //     Console.WriteLine("What is a short description for it? ");
    //     goalDesc = Console.ReadLine();
    //     Console.WriteLine();
    //     Console.WriteLine("What is the amount of points with this goal? ");
    //     goalPoints = int.Parse(Console.ReadLine());
    //     Console.WriteLine();   
    // }

    public string GetDesc()
    {
        return goalDesc;
    } 
    public string GetName()
    {
        return goalName;
    }
    public int GetPoints()
    {
        return goalPoints;
    }
    public override string ToString()
    {
        return $"{goalName}: {goalDesc}, {goalPoints}";
    }
}
