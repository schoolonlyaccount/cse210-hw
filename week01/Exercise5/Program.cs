using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int squared_number = SquareNumber(user_number);

        DisplayResult(user_name, squared_number);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string user_input = Console.ReadLine();
        return int.Parse(user_input);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squared_number)
    {
        Console.WriteLine($"{name}, the square of your number is {squared_number}");
    }
}