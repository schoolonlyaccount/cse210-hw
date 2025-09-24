public class Video
{
    private string _title;
    private string _author;
    private int _length; // In seconds
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetLengthInSeconds() => _length;
    public int GetLengthInMinutes() => _length / 60;
    public int GetLengthInHours() => _length / 3600;
    public string GetLengthAsTime()
    {
        int hours = _length / 3600;
        int minutes = (_length % 3600) / 60;
        int seconds = _length % 60;

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }
    public int GetNumberOfComments() => _comments.Count();
    public void AddComment(string name, string text) => _comments.Add(new Comment(name, text));
    public void DisplayInformation()
    {
        Console.WriteLine($"Title: {GetTitle()} - Author: {GetAuthor()} - Length: {GetLengthAsTime()}");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");
        foreach (Comment c in _comments)
        {
            Console.WriteLine($"> {c.GetName()}: {c.GetText()}");
        }
    }
}