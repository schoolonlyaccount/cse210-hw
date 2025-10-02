public class ReflectionActivity : Activity
{
    // Attributes
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private Random randomGenerator = new Random();

    // Constructor
    public ReflectionActivity()
    {
        SetName("Reflection Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    // Methods
    public void Run()
    {
        // ...
        DisplayStartingMessage();

        // ...
        Console.WriteLine();

        // ...
        DisplayPrompt();

        // Loop until session is over
        DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
        }

        // ...
        Console.WriteLine();

        // ...
        DisplayEndingMessage();
    }

    public string GetRandomPrompt() => _prompts[randomGenerator.Next(0, _prompts.Count())];
    public string GetRandomQuestion() => _questions[randomGenerator.Next(0, _questions.Count())];
    public void DisplayPrompt()
    {
        // Display a random prompt
        Console.WriteLine($"Consider the following prompt:\n\n--- {GetRandomPrompt()} ---");

        // Allows the user to decide when to continue
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        // Display countdown
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        // ...
        Console.Clear();
    }
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(10);
        Console.WriteLine();
    }
}