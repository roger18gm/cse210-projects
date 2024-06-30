public class CreateGoal 
{
    private string goalChoice;

    private int timesCompleted = 0;
    private bool isComplete = false;

    public Goal SelectGoal()    
    {
        Console.WriteLine("The types of goals are");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalChoice = Console.ReadLine();
        
        Goal goal = null;

        switch(goalChoice)
        {
            case "1":
                goal = SimpleGoalCreation();
                break;
            case "2":
                goal = EternalGoalCreation();
                break;
            case "3":
                goal = ChecklistGoalCreation();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        return goal;

    }

    private Goal SimpleGoalCreation()
    {
        Console.WriteLine("What is the name of the goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is a short description for it? ");
        string goalDesc = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is the amount of points with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        Console.WriteLine();   

        return new SimpleGoal(goalName, goalDesc, goalPoints, isComplete);
    }

    private Goal EternalGoalCreation()
    {
        Console.WriteLine("What is the name of the goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is a short description for it? ");
        string goalDesc = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is the amount of points with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        Console.WriteLine();   

        return new EternalGoal(goalName, goalDesc, goalPoints);
    }

    private Goal ChecklistGoalCreation()
    {
        Console.WriteLine("What is the name of the goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is a short description for it? ");
        string goalDesc = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is the amount of points with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        Console.WriteLine();   
        Console.WriteLine("How many times does this goal need to repeat for a bonus? ");
        int goalRepeat = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("What is the bonus amount for achieving this goal? ");
        int goalBonus = int.Parse(Console.ReadLine());
        Console.WriteLine();

        return new ChecklistGoal(goalName, goalDesc, goalPoints, goalRepeat, timesCompleted, goalBonus);
    }
}