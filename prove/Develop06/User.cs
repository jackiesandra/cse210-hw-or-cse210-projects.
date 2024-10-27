using System;
using System.Collections.Generic;

public class User
{
    public string Name { get; set; }
    public int TotalPoints { get; private set; }
    private List<Goal> goals;

    public User(string name)
    {
        Name = name;
        TotalPoints = 0;
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"{Name}'s Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetGoalInfo());
        }
    }

    public void RecordEvent(Goal goal)
    {
        if (goals.Contains(goal))
        {
            goal.RecordProgress();
            TotalPoints += goal.Points;
            Console.WriteLine($"Recorded progress for: {goal.Title}. Total Points: {TotalPoints}");
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }
}
