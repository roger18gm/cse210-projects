public class RecordGoals
{
    private Menu m;
    public RecordGoals(Menu m)
    {
        this.m = m;
    }
    public void UpdateGoal(List<Goal> goals)
    {
        int index = 1;
        Console.WriteLine("The goals are:");

        foreach(var goal in goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index ++;
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Goal selectedGoal = goals[choice -1];
        selectedGoal.RecordEvent();
        int pointsEarned = selectedGoal.GetPoints();
        m.AddPoints(pointsEarned);

        if (selectedGoal is ChecklistGoal cgl) 
        {
            int bonusPoints = cgl.GetGoalBonus();

            if (cgl.GetGoalRepeat() == cgl.GetTimesCompleted())
            {
                m.AddPoints(bonusPoints);

                pointsEarned += bonusPoints;
            } 
        }

        Console.WriteLine($"Congratulations you have earned {pointsEarned} points!");

        Console.WriteLine($"You now have {m.GetCurrentPoints()} points.");
    }

   
}