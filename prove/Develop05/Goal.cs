public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool Completed { get; protected set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        Completed = false;
    }

    public abstract int RecordEvent();

    public void SetCompleted(bool completed)
    {
        Completed = completed;
    }

    public override string ToString()
    {
        string status = Completed ? "[X]" : "[ ]";
        return $"{status} {Name} - {Points} points";
    }
}
