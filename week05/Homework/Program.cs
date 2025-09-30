using System;

class Program
{
    static void Main(string[] args)
    {
        void LineBreaker() => Console.WriteLine("<>");

        Console.Clear();

        Assignment a1 = new Assignment("Kell Brine", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        LineBreaker();

        MathAssignment a2 = new MathAssignment("Kell Brine", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        LineBreaker();

        WritingAssignment a3 = new WritingAssignment("Kell Brine", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}