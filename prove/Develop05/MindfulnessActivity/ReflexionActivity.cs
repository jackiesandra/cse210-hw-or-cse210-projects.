public class ReflectionActivity : MindfulnessActivity
{
    private string[] questions = {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something really difficult."
    };

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "This activity will help you reflect on moments in your life where you showed strength.";
    }

    public void Execute()
    {
        StartActivity();

        Random rand = new Random();
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine(questions[rand.Next(questions.Length)]);
            Thread.Sleep(10000); // Time for reflection
        }

        EndActivity();
    }
}
