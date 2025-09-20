using System;
using System.ComponentModel;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Stored scriptures
        Scripture myScripture1 = new Scripture(new Reference("Moroni", 7, 46, 47), "Wherefore, my beloved brethren, if ye have not charity, ye are nothing, for charity never faileth. Wherefore, cleave unto charity, which is the greatest of all, for all things must fail— But charity is the pure love of Christ, and it endureth forever; and whoso is found possessed of it at the last day, it shall be well with him.");

        // Clear the console screen
        Console.Clear();

        // Prompt the user on the difficulty
        int wordsToHide;
        while (true)
        {
            Console.WriteLine("Choose a Difficulty: 1 = Easy, 2 = Medium, 3 = Hard");
            string userInput = Console.ReadLine();

            if (userInput == "1" || userInput == "2" || userInput == "3") { wordsToHide = int.Parse(userInput) * 2; break; }
            else
            {
                Console.WriteLine("Invaild option! Please try again.");
            }
        }

        // Loop (until the user enters "quit" or until all the words in the scripture have been hidden)
        while (true)
        {
            // Clear the console screen
            Console.Clear();

            // Display the difficulty
            Console.WriteLine($"Difficulty: {(wordsToHide == 2 ? "Easy" : wordsToHide == 4 ? "Medium" : wordsToHide == 6 ? "Hard" : 0)}, Hiding {wordsToHide} words every continue.\n");

            // Display the scripture reference and verse(s)
            Console.WriteLine(myScripture1.GetDisplayText());

            // Prompt the user on whether or not they would like to quit the program
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            if (Console.ReadLine().ToLower() == "quit") { break; }

            // Quit the program if all words are completely hidden
            if (myScripture1.IsCompletelyHidden()) { break; }

            // Hide random words then repeat the loop
            myScripture1.HideRandomWords(wordsToHide);
        }
    }
}