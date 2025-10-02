public class Activity
{
    // Attributes
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity()
    {
        // Nothing
    }

    // Methods
    public void DisplayStartingMessage()
    {
        // ...
        Console.Clear();

        // Display the activity's name and description
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n");

        // Prompt and get user's desired session length (in seconds)
        Console.Write("How long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));

        // ...
        Console.Clear();

        // Pause with spinner for a moment
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }
    public void DisplayEndingMessage()
    {
        // Pause with spinner for a moment
        Console.WriteLine("Well done!!");
        ShowSpinner();

        // Pause with spinner for a moment
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
        ShowSpinner();
    }
    public void ShowSpinner(int seconds = 4)
    {
        // Loop until "seconds" is less than 0
        while (seconds > 0)
        {
            Console.Write(" \b-\b");
            Thread.Sleep(250);

            Console.Write(" \b\\\b");
            Thread.Sleep(250);

            Console.Write(" \b|\b");
            Thread.Sleep(250);

            Console.Write(" \b/\b");
            Thread.Sleep(250);
            seconds--;
        }
        Console.Write(" \b \b");
    }
    public void ShowCountDown(int seconds)
    {
        // Loop until "seconds" is less than 0
        while (seconds > 0)
        {
            Console.Write($" \b{seconds}\b");
            Thread.Sleep(1000);
            seconds--;
        }
        Console.Write(" \b\b");
    }
    public void SetName(string name) => _name = name;
    public void SetDescription(string description) => _description = description;
    public void SetDuration(int duration) => _duration = duration;
    public int GetDuration() => _duration;
}