using System;
using System.Threading;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Display the menu
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("      Mindfulness Program");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Exit");
                Console.WriteLine("-----------------------------------");
                Console.Write("Enter your option (1-4): ");

                // Read user input
                string input = Console.ReadLine();
                int choice;

                // Validate input
                if (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid option. Please choose an option from 1 to 4.");
                    continue;
                }

                // Declare the activity
                MindfulnessActivity activity = null;

                // Select the activity based on user choice
                switch (choice)
                {
                    case 1:
                        activity = new BreathActivity();
                        break;
                    case 2:
                        activity = new ReflectionActivity();
                        break;
                    case 3:
                        activity = new ListingActivity();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the program! Goodbye.");
                        return; // Exit the program
                }

                // Execute the selected activity
                
            }
        }
    }
}
