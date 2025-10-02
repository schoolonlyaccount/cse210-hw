using System;
using System.Collections.Generic;

// Showing Creativity and Exceeding Requirements:
// 1. Created the Print() and Input() functions from Python
// 2. Keeping a log of how many times certain activities were performed

class Program
{
    static void Main(string[] args)
    {
        // Activity run times (in single program session)
        int bA = 0, rA = 0, lA = 0;

        // Menu System
        while (true)
        {
            // Clear the terminal
            Console.Clear();

            // List the activity options for the user
            Print($"Menu Options:\n1. Start breathing activity (Ran {bA}x)\n2. Start reflection activity (Ran {rA}x)\n3. Start listing activity (Ran {lA}x)\n4. Quit");

            // Get user's input
            string userInput = Input("Select a choice from the menu: ");

            // Goto user's desired option
            switch (userInput)
            {
                // Breathing
                case "1":
                    new BreathingActivity().Run();
                    bA++;
                    break;

                // Reflection
                case "2":
                    new ReflectionActivity().Run();
                    rA++;
                    break;

                // Listing
                case "3":
                    new ListingActivity().Run();
                    lA++;
                    break;

                // Quit
                case "4":
                    Environment.Exit(0);
                    break;

                // Invalid
                default:
                    Input("\nInvalid option!\nPress enter to try again...");
                    break;
            }
        }
    }

    // Mimic Python's print() function
    static void Print(string message, bool newline = true)
    {
        if (newline) { Console.WriteLine(message); }
        else { Console.Write(message); }
    }

    // Mimic Python's input() function
    static string Input(string prompt)
    {
        Print(prompt, newline: false);
        return Console.ReadLine();
    }
}