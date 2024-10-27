public abstract class Goal
{
    public string Title { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string title, int points)
    {
        Title = title;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordProgress();
    public abstract string GetGoalInfo();
}
