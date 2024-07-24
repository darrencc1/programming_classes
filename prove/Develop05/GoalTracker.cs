using System;
using System.Collections.Generic;
using System.IO;
// I could not get this tro work, I used chat gpt, my own troubleshooting and google, I just ran out of time and think I am misunderstanding somthing simple. 
public class GoalTracker
{
    private List<Goal> goals;
    private int totalPoints;

    public GoalTracker()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                totalPoints += goal.RecordEvent();
                break;
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalPoints}");
    }

    public void ShowGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                string goalType = goal.GetType().Name;
                file.WriteLine($"{goal.Name},{goal.Points},{goal.Completed},{goalType}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        using (StreamReader file = new StreamReader(filename))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int points = int.Parse(parts[1]);
                bool completed = bool.Parse(parts[2]);
                string goalType = parts[3];

                Goal goal;
                if (goalType == nameof(SimpleGoal))
                {
                    goal = new SimpleGoal(name, points);
                }
                else if (goalType == nameof(EternalGoal))
                {
                    goal = new EternalGoal(name, points);
                }
                else if (goalType == nameof(ChecklistGoal))
                {
                    goal = new ChecklistGoal(name, points, 10, 500); 
                }
                else
                {
                    continue;
                }
                goal.SetCompleted(completed);
                AddGoal(goal);
            }
        }
    }
}
