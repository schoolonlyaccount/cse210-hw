using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter numbers in and how to stop
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // The List
        List<int> numbers = new List<int>();

    // Label #1
    entering_numbers:
        // Entering a number
        Console.Write("Enter number: ");
        string user_input = Console.ReadLine();
        int number = int.Parse(user_input);

        // We're done
        if (number == 0)
        {
            goto results;
        }

        // Add the number to the list
        numbers.Add(number);

        // Jump back
        goto entering_numbers;

    // Label #2
    results:
        // Calculate
        int list_sum = numbers.Sum();
        decimal list_average = (decimal)list_sum / numbers.Count();
        int largest_number = 0;
        int smallest_positive_number = 0;
        for (int i = 0; i < numbers.Count(); i++)
        {
            // Determine the largest number
            largest_number = (numbers[i] > largest_number ? numbers[i] : largest_number);

            // Determine the smallest positive number
            if (smallest_positive_number == 0 && numbers[i] > 0)
            {
                smallest_positive_number = numbers[i];
            }
            else
            {
                smallest_positive_number = ((numbers[i] < smallest_positive_number && numbers[i] > 0) ? numbers[i] : smallest_positive_number);
            }
        }
        numbers.Sort();

        // Display
        Console.WriteLine($"The sum is: {list_sum}");
        Console.WriteLine($"The average is: {list_average}");
        Console.WriteLine($"The largest number is: {largest_number}");
        Console.WriteLine($"The smallest positive number is: {smallest_positive_number}");
        Console.WriteLine($"The sorted list is:");
        foreach (int value in numbers)
        {
            Console.WriteLine($"{value}");
        }

    }
}