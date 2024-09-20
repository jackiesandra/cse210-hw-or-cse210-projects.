using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        // Variable for the letter grade
        string letter = "";

        // Determine the letter grade
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Message to indicate if the user passed or not
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

        // Determine the "+" or "-" sign if applicable
        string sign = ""; // Variable for the sign
        if (letter != "F") // No sign for F
        {
            int lastDigit = percent % 10; // Get the last digit
            if (lastDigit >= 7)
            {
                sign = "+"; // Positive sign
            }
            else if (lastDigit < 3)
            {
                sign = "-"; // Negative sign
            }
        }

        // Handle the special case for A
        if (letter == "A" && sign == "+")
        {
            letter = "A"; // No A+ grade
        }

        // Show the final grade
        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}
