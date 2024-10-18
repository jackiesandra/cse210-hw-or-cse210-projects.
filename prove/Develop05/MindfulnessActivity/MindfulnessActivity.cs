public class MindfulnessActivity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public void StartActivity()
    {
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine(Description);
        Console.WriteLine("How many seconds would you like to dedicate to this activity?");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
    }

    public void EndActivity()
    {
        Console.WriteLine("Great job! You've completed the activity.");
        Thread.Sleep(3000);
    }
}
