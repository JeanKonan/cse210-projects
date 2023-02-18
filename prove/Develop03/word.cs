using System;

public class Word
{
    private string _content;

    public Word()
    {

    }

    public string GetWord()
    {
        return _content;
    }

    public void SetWord(string _word)
    {
        _content = _word;
    }

    public void Show()
    {
        Console.Write($"{_content} ");
    }

    public void Hide()
    {
       SetWord("____");
    }
}