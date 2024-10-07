// This program exceeds the requirements by implementing random scripture selection 
// and allowing for loading scriptures from a file in future versions.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Load a random scripture
        var scripture = GetRandomScripture();
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

    static Scripture GetRandomScripture()
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding."),
            // Add more scriptures here
        };

        Random random = new Random();
        return scriptures[random.Next(scriptures.Count)];
    }
}
