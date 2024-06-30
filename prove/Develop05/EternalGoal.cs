public class EternalGoal : Goal
{
    private bool isComplete;
    public EternalGoal(string goalName, string goalDesc, int goalPoints) : base (goalName,goalDesc, goalPoints)
    {
        isComplete = false;
    } 

    public override string RecordEvent()
    {
        isComplete = true;
        return "[ ]";
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string ToString()
    {
        return $"{(isComplete ? "[ ]" : "[ ]")} {GetName()} ({GetDesc()})";
    }

}