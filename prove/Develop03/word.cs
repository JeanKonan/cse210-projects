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
        string _hidden_word = string.Empty;
        foreach (char letter in _content)
        {
            if (letter != '.' || letter != ',' || letter != ';' || letter != ':' || letter != '!' || letter != '?')
            {
                _hidden_word += '_';
            }
        }
        SetWord(_hidden_word);
    }
}