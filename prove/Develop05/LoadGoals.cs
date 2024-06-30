using System.IO;
using System.Linq;
public class LoadGoals
{
    private string currentDirectory;
    private string fileName;

    public LoadGoals()
    {
        currentDirectory = Directory.GetCurrentDirectory();
    }
    
    public void FindFile(List<Goal>goals, Menu m)
    {
        Console.Write("What is the name of the file? ");
        fileName = Console.ReadLine();

        string filePath = Path.Combine(currentDirectory, fileName);

        if (File.Exists(filePath))
        {
            ConvertFiletoObject(filePath, goals, m);
        }
        else
        {
            Console.WriteLine("File not found in current working directory.");
        }
    }

    public void ConvertFiletoObject(string filePath, List<Goal>goals, Menu m)
    {
        var lines = File.ReadAllLines(filePath);

        int currentPoints = int.Parse(lines[0]);

        m.SetCurrentPoints(currentPoints);

        foreach(string line in lines.Skip(1))
        {
            string[] firstPart = line.Split(":");
            string goalType = firstPart[0];
            string goalSpecs = firstPart[1];

            string [] secondPart = goalSpecs.Split("~");
            string goalName = secondPart[0];
            string goalDesc = secondPart[1];
            int goalPoints = int.Parse(secondPart[2]);

            Goal newGoal = null;

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(secondPart[3]);
                    newGoal = new SimpleGoal(goalName, goalDesc, goalPoints, isComplete);
                    break;
                case "EternalGoal":
                    newGoal = new EternalGoal(goalName, goalDesc, goalPoints);
                    break;
                case "ChecklistGoal":
                    int goalRepeat = int.Parse(secondPart[3]);
                    int timesCompleted = int.Parse(secondPart[4]);
                    int goalBonus = int.Parse(secondPart[5]);
                    newGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, goalRepeat, timesCompleted, goalBonus);
                    break;
                default:
                    Console.WriteLine("Unknown goal type found in file.");
                    break;
            }

            goals.Add(newGoal);
        }
    }
}