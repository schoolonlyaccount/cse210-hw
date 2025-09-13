public class PromptGenerator
{
    private Random randomGenerator = new Random();
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        return _prompts[randomGenerator.Next(0, _prompts.Count())];
    }
}