public class ChecklistGoal : Goal
{
    private int goalRepeat;
    private int goalBonus;
    private int timesCompleted;
    private bool isComplete;

    public ChecklistGoal(string goalName, string goalDesc, int goalPoints,int goalRepeat, int timesCompleted, int goalBonus) : base (goalName, goalDesc, goalPoints)
    {
        this.goalRepeat = goalRepeat;
        this.goalBonus = goalBonus;
        this.timesCompleted = timesCompleted;
        isComplete = false;
    } 

    public override string RecordEvent()
    {
        timesCompleted ++;

        if (timesCompleted == goalRepeat){
            isComplete = true;
            return "[X]";
        }
        else {
            return "[ ]";
        }
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public int GetGoalRepeat()
    {
        return goalRepeat;
    }

    public int GetTimesCompleted()
    {
        return timesCompleted;
    }
    public int GetGoalBonus()
    {
        return goalBonus;
    }
    public override string ToString()
    {
        return $"{(isComplete ? "[X]" : "[ ]")} {GetName()} ({GetDesc()}) -- Currently Completed: {timesCompleted}/{goalRepeat}";
    }
}