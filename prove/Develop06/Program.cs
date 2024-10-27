using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Jacky");

            // Create goals
            var goal1 = new SimpleGoal("Read Scriptures", 100);
            var goal2 = new EternalGoal("Pray Every Day", 50);
            var goal3 = new ChecklistGoal("Attend the Temple", 50, 10);

            // Add goals to the user
            user.AddGoal(goal1);
            user.AddGoal(goal2);
            user.AddGoal(goal3);

            // Record some events
            user.RecordEvent(goal1);
            user.RecordEvent(goal2);
            user.RecordEvent(goal3);
            
            // Display all goals and total score
            user.DisplayGoals();
            Console.WriteLine($"Total Score: {user.TotalPoints}");
        }
    }
}
