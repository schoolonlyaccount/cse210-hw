using System;

class Program
{
    static void Main(string[] args)
    {
        // Setting the magic number, randomly
        Random random_generator = new Random();
        int magic_number = random_generator.Next(1, 101);

    // Label - legacy looping
    guessing:

        // Get the user's guess
        Console.Write("What is your guess? ");
        string user_input = Console.ReadLine();
        int user_guess = int.Parse(user_input);

        // Check the user's guess
        if (user_guess == magic_number)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (user_guess > magic_number)
        {
            Console.WriteLine("Lower");

            // Jump back to label "guessing"
            goto guessing;
        }
        else if (user_guess < magic_number)
        {
            Console.WriteLine("Higher");

            // Jump back to label "guessing"
            goto guessing;
        }
    }
}