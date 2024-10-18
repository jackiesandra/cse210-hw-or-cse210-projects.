public class ListingActivity : MindfulnessActivity
{
    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by listing as many as you can.";
    }

    public void Execute()
    {
        StartActivity();

        Console.WriteLine("Who are the people you appreciate?");
        Thread.Sleep(5000); // Time to think

        // Logic to allow user to input items can be added here
        // Example: Count and display the number of items

        EndActivity();
    }
}
