public class ListingActivity : Activity
{
    // Attributes
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private Random randomGenerator = new Random();

    // Constructor
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    // Methods
    public void Run()
    {
        // ...
        DisplayStartingMessage();

        // ...
        Console.WriteLine();

        // ...
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        // ...
        Console.WriteLine();

        // Loop until session is over
        DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        // ...
        Console.WriteLine($"You listed {_count} items!\n");

        // ...
        DisplayEndingMessage();
    }

    public string GetRandomPrompt() => _prompts[randomGenerator.Next(0, _prompts.Count())];
    public List<string> GetListFromUser() => new List<string>(); // Never used or needed
}