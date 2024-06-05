using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 600);
        Video video3 = new Video("C# Best Practices", "Emily Johnson", 450);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Thanks for the tutorial."));

        video2.AddComment(new Comment("David", "I learned a lot."));
        video2.AddComment(new Comment("Eve", "This was a bit too advanced for me."));
        video2.AddComment(new Comment("Frank", "Excellent content!"));

        video3.AddComment(new Comment("Grace", "Very well explained."));
        video3.AddComment(new Comment("Hank", "Can you make more videos like this?"));
        video3.AddComment(new Comment("Ivy", "I appreciate the effort you put into this."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list and display video details
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine();
        }
    }
}