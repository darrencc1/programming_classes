public class ChecklistGoal : Goal
{
    public int CurrentCount { get; private set; }
    public int TargetCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        CurrentCount = 0;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            Completed = true;
            return Points + BonusPoints;
        }
        return Points;
    }

    public override string ToString()
    {
        string status = Completed ? "[X]" : "[ ]";
        return $"{status} {Name} - {Points} points (Completed {CurrentCount}/{TargetCount} times)";
    }
}
