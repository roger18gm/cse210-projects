using System.Diagnostics;
using System.Net;

public class SimpleGoal : Goal
{
    private bool isComplete;
    public SimpleGoal(string goalName, string goalDesc, int goalPoints, bool isComplete) : base (goalName, goalDesc, goalPoints)
    {
        this.isComplete = isComplete;
    } 

    public override string RecordEvent()
    {
        isComplete = true;
        return "[X]";
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string ToString()
    {
        return $"{(isComplete ? "[X]" : "[ ]")} {GetName()} ({GetDesc()})";
    }
}