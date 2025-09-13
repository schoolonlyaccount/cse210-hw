using System;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;
using System.IO;
using System.Collections.Generic;

// Showing Creativity and Exceeding Requirements: Saved information on who the entry was from

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message and setup important variables
        Console.WriteLine("Hello! Welcome to your journal!\n");
        int menuRepeat = 1;
        bool areDone = false;

        // Create my journal
        Journal myJournal = new Journal();

        // Create my random prompts
        PromptGenerator myPrompts = new PromptGenerator();
        myPrompts._prompts.Add("Who was the most interesting person I interacted with today?");
        myPrompts._prompts.Add("What was the best part of my day?");
        myPrompts._prompts.Add("How did I see the hand of The Lord in my life today?");
        myPrompts._prompts.Add("What was the strongest emotion I felt today?");
        myPrompts._prompts.Add("if I had one thing I could do over today, what would it be?");

        // Loop until user is done with the journal
        while (areDone == false)
        {
            // Display the top menu border and add to "menuRepeat" variable
            Console.WriteLine($"<------------Repeat #{menuRepeat}------------>");
            menuRepeat++;

            // Display the options
            Console.WriteLine("1. New Entry\n2. Display Journal\n3. Save Journal\n4. Load Journal\n5. Exit Program\n");

            // Prompt and get the user's input
            Console.Write("Please enter the number of the option you want: ");
            string userInput = Console.ReadLine();

            // Direct to user's desired option
            switch (userInput)
            {
                // New Entry
                case "1":
                    // Get entry data #1
                    Entry myEntry = new Entry();
                    myEntry._date = DateTime.Now.ToString(); // Get the current date
                    myEntry._promptText = myPrompts.GetRandomPrompt(); // Get a random prompt

                    // Get entry data #2
                    Console.Write($"Who is this: "); // Ask the user who is entry is from
                    myEntry._name = Console.ReadLine(); // Get the user's input

                    // Get entry data #3
                    Console.Write($"Entry prompt: {myEntry._promptText}\nYour answer: "); // Display the random prompt
                    myEntry._entryText = Console.ReadLine(); // Get the user's input

                    // Save entry
                    myJournal.AddEntry(myEntry);
                    break;

                // Display Journal
                case "2":
                    myJournal.DisplayAll();
                    break;

                // Save Journal
                case "3":
                    // Prompt and get the user's filename
                    Console.Write("Enter a filename: ");
                    userInput = Console.ReadLine();

                    // Save journal to a file
                    Console.WriteLine(myJournal.SaveToFile(userInput));
                    break;

                // Load Journal
                case "4":
                    // Prompt and get user's filename
                    Console.Write("Enter a filename: ");
                    userInput = Console.ReadLine();

                    // Load a journal
                    Console.WriteLine(myJournal.LoadFromFile(userInput));
                    break;

                // Exit Program
                case "5":
                    areDone = true;
                    break;

                // Invalid option
                default:
                    Console.WriteLine("Invalid option!\n");
                    continue;
            }

            // Create blank line
            Console.WriteLine("");
        }
    }
}