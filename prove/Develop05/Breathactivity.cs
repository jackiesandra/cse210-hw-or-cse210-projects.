public class BreathActivity : MindfulnessActivity
{
    public BreathActivity()
    {
        Name = "Breath Activity";
        Description = "This activity will help you relax while inhaling and exhaling slowly.";
    }

    public void Execute()
    {
        StartActivity();

        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Inhale...");
            Thread.Sleep(5000);
            Console.WriteLine("Exhale...");
            Thread.Sleep(5000);
        }

        EndActivity();
    }
}
