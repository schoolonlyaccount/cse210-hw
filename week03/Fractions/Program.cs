using System;

class Program
{
    static void Main(string[] args)
    {
        void Display(Fraction className)
        {
            Console.WriteLine(className.GetFractionString());
            Console.WriteLine(className.GetFractionValue());
        }

        Fraction numbers1 = new Fraction(); Display(numbers1);

        Fraction numbers2 = new Fraction(5); Display(numbers2);

        Fraction numbers3 = new Fraction(3, 4); Display(numbers3);

        Fraction numbers4 = new Fraction(1, 3); Display(numbers4);
    }
}