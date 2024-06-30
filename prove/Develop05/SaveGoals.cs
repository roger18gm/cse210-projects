using System.IO;

public class SaveGoals
{
    private string fileName;
    private Menu m;
    public SaveGoals(Menu m)
    {
        this.m = m;
    }
    public void WriteGoals(List<Goal>goals)
    {
        Console.Write("What is the name of the file? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(m.GetCurrentPoints());

            foreach(var goal in goals)
            {
                 if (goal is ChecklistGoal cgl)
                {
                    outputFile.WriteLine($"ChecklistGoal:{goal.GetName()}~{goal.GetDesc()}~{goal.GetPoints()}~{cgl.GetGoalRepeat()}~{cgl.GetTimesCompleted()}~{cgl.GetGoalBonus()}");
                }
                else if (goal is SimpleGoal sg)
                {
                    outputFile.WriteLine($"SimpleGoal:{goal.GetName()}~{goal.GetDesc()}~{goal.GetPoints()}~{sg.IsComplete()}");
                }
                else if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"EternalGoal:{goal.GetName()}~{goal.GetDesc()}~{goal.GetPoints()}");
                }
                
            }
        }
    }
}


 