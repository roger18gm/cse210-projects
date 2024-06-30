using System.Runtime.InteropServices.Marshalling;

public class Menu
{
    bool running = true;

    private int currentPoints = 0;
    List<Goal> goals = new List<Goal>();
    CreateGoal c = new CreateGoal();
    ListGoals lg = new ListGoals();
    LoadGoals l = new LoadGoals();
    public void Main()
    {   
        SaveGoals sg = new SaveGoals(this);
        RecordGoals rg = new RecordGoals(this);
        
        while (running) 
        {
            // Console.Clear();
            Console.WriteLine($"You have {GetCurrentPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Goal newGoal = c.SelectGoal();
                    goals.Add(newGoal);
                    break;
                case "2":
                    lg.DisplayGoals(goals);
                    break;
                case "3":
                    sg.WriteGoals(goals);
                    break;
                case "4":
                    l.FindFile(goals, this);
                    break;
                case "5":
                    rg.UpdateGoal(goals);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            // Console.WriteLine("Press any key to continue...");
            // Console.ReadKey();
        }
    }

    public virtual int GetCurrentPoints()
    {
        return currentPoints;
    }
    public void AddPoints(int points)
    {
        currentPoints += points;    
    }

    public void SetCurrentPoints(int points)
    {
        currentPoints = points;
    }
}
