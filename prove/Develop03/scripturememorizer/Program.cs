using System;

class Program
{
    static void Main(string[] args)
    {
        // Load an example scripture
        var scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding.");
        Console.Clear();

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");

            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
            Console.Clear();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are now hidden. Goodbye!");
                break;
            }
        }
    }
}

