public class SimpleGoal : Goal
{
    public SimpleGoal(string title, int points) : base(title, points) { }

    public override void RecordProgress()
    {
        IsCompleted = true;
    }

    public override string GetGoalInfo()
    {
        return IsCompleted ? $"[X] {Title} (Completed, +{Points} points)" : $"[ ] {Title} (Not completed)";
    }
}
