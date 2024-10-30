using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creates videos
        var video1 = new Video("Learning Programming Languages", "Alejandro Alvarez", 1500);
        var video2 = new Video("Best MTB Hardtail - 2024", "Steve W.", 1000);
        var video3 = new Video("Living in Calgary", "Donna Molly", 1600);

        // Adds comments to video1
        video1.AddComment(new Comment("Alice", "Thank you for this explanation about programming languages!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make a video about the 4 Principles of Porgramming with Classes in c#?"));

        // Adds comments to video2
        video2.AddComment(new Comment("David", "Nice review! I have never thought about this bike!"));
        video2.AddComment(new Comment("Eve", "It seems to be a solid option for the trails I want to try!"));
        video2.AddComment(new Comment("Frank", "Hi, I liked the specs and price point for this bike. Is it sold in Europe too?"));

        // Adds comments to video3
        video3.AddComment(new Comment("Grace", "I have been thinking about moving to Canada, this video helped me to decide, I want to go to Calgary!"));
        video3.AddComment(new Comment("Heidi", "This is a lot more different than UK... Would like to try..."));
        video3.AddComment(new Comment("Ivan", "Its seems amazing to live in one of the most clean cities in the world..."));

        // Stores videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(); // Add an empty line for better readability
        }
    }
}