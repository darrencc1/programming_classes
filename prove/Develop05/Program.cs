using System;

public class Program
{
    public static void Main()
    {
        GoalTracker tracker = new GoalTracker();

      
        tracker.AddGoal(new SimpleGoal("Run 10 miles", 1000));
        tracker.AddGoal(new EternalGoal("Read scriptures", 25));
        tracker.AddGoal(new ChecklistGoal("Go to the temple", 10, 10, 100));

        tracker.RecordEvent("Read scriptures");
        tracker.RecordEvent("Attend temple");
        tracker.RecordEvent("Attend temple");

        tracker.ShowGoals();
        tracker.DisplayScore();

        tracker.SaveGoals("goals.txt");
        tracker.LoadGoals("goals.txt");
    }
}
