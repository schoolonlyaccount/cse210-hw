using System;
using System.ComponentModel.Design;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Youtube Video instances
        Video myVideo1 = new Video("How to build a boat", "Noah", 5713);
        myVideo1.AddComment("Bob", "Thanks! Was helpful!");
        myVideo1.AddComment("Natily", "Just what I needed!");
        myVideo1.AddComment("Alex", "Decent video, bro.");
        Video myVideo2 = new Video("God's 10 commandments", "Moses", 335);
        myVideo2.AddComment("Crystal", "Love it!");
        myVideo2.AddComment("Aubrey", "Wish everyone would follow these.");
        myVideo2.AddComment("Angel", "You're the best!");
        Video myVideo3 = new Video("Story of my life", "Joseph", 46973);
        myVideo3.AddComment("Nick", "Very interesting.");
        myVideo3.AddComment("Cody", "How did I get here.");
        myVideo3.AddComment("Mandy", "Love your humility!");

        // List holding the Youtube Videos
        List<Video> myVideos = new List<Video> { myVideo1, myVideo2, myVideo3 };

        // Display the Youtube Videos
        Console.Clear();
        myVideos.ForEach(v => v.DisplayInformation());
    }
}