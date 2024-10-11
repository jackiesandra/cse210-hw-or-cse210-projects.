using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("Learning C#", "John Doe", 300);
        video1.AddComment(new Comment("Ana", "Great video!"));
        video1.AddComment(new Comment("Luis", "Very informative."));
        video1.AddComment(new Comment("Carlos", "Thanks for the tips."));
        
        Video video2 = new Video("Understanding OOP", "Maria Garcia", 450);
        video2.AddComment(new Comment("David", "I love this explanation."));
        video2.AddComment(new Comment("Eva", "Could you explain more about encapsulation?"));
        
        Video video3 = new Video("Mastering Algorithms", "Miguel Lopez", 600);
        video3.AddComment(new Comment("Francisco", "Awesome content!"));
        video3.AddComment(new Comment("Gabriela", "I can't wait for the next one."));
        
        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information about the videos
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
