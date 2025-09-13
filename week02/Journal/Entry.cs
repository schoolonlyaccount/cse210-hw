public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _name;

    public void Display()
    {
        Console.WriteLine($"Time: {_date} - Prompt: {_promptText} - Answer: {_entryText} - From: {_name}");
    }
}