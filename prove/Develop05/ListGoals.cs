
public class ListGoals
{  
    public void DisplayGoals(List<Goal>goals)
    {
        int count = 1;

        Console.WriteLine("The goals are: ");
        foreach (var goal in goals)
        {
            if (goal is ChecklistGoal clg)
            {
                Console.WriteLine($"{count}.{goal}");
            }
            else
            {
                Console.WriteLine($"{count}.{goal}");
            }
            count++;
        }
    }
}