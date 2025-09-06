using System;

class Program
{
    static void Main(string[] args)
    {
        // Get User's Score
        Console.Write("What is your grade percentage? ");
        string user_input = Console.ReadLine();
        float user_score = float.Parse(user_input);

        // Ternary Operator Check (Shorthand Of "If, else if, else")
        string user_grade = (
            user_score >= 90 ? "A" :
                user_score >= 80 ? "B" :
                    user_score >= 70 ? "C" :
                        user_score >= 60 ? "D" : "F"

            );

        // Show User's Grade
        Console.WriteLine($"\nYour grade: {user_grade}");

        // Congratulations Message If They Passed, And An Encouragement If Not
        if (user_score >= 70)
        {
            Console.WriteLine("\nCongratulations on passing!");
        }
        else
        {
            Console.WriteLine("\nDon't give up! You'll get it next time!");
        }

    }
}