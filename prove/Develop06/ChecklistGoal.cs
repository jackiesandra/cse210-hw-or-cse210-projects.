public class ChecklistGoal : Goal
{
    private int totalTimes;
    private int completedTimes;

    public ChecklistGoal(string title, int points, int totalTimes) : base(title, points)
    {
        this.totalTimes = totalTimes;
        this.completedTimes = 0;
    }

    public override void RecordProgress()
    {
        if (completedTimes < totalTimes)
        {
            completedTimes++;
            Points += Points; // Each time it’s recorded, gain points

            if (completedTimes == totalTimes)
            {
                Points += 500; // Bonus for completing all
                IsCompleted = true;
            }
        }
    }

    public override string GetGoalInfo()
    {
        return IsCompleted 
            ? $"[X] {Title} (Completed, +{Points} points)" 
            : $"[ ] {Title} (Completed {completedTimes}/{totalTimes} times)";
    }
}
