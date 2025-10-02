public class BreathingActivity : Activity
{
    // Attributes
    // Nothing

    // Constructor
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    // Methods
    public void Run()
    {
        // ...
        DisplayStartingMessage();

        // ...
        Console.WriteLine("\n");

        // Loop until session is over
        DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine("\n");
        }

        // ...
        DisplayEndingMessage();
    }
}