// Keeps track of the book, chapter, and verse information.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse <= 0 ? verse : endVerse;
    }

    public string GetDisplayText()
    {
        return _verse == _endVerse ? $"{_book} {_chapter}:{_verse}" : $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}