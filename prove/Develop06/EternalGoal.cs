public class EternalGoal : Goal
{
    public EternalGoal(string title, int points) : base(title, points) { }

    public override void RecordProgress()
    {
        // Increment score but keep it ongoing
    }

    public override string GetGoalInfo()
    {
        return $"[ ] {Title} (Ongoing, +{Points} points each time)";
    }
}
