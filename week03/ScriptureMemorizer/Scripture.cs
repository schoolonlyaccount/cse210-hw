// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;

        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}