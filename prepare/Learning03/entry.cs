using System;

class Entry
{
    public DateTime _date;
    public string _question;
    public string _answer;

    //public List<string> _content = new List<string>();

    public Entry()
    {

    }

    public void Hold(List<string> _content)
    {
            _content.Add ($"{_date.ToShortDateString()},{_question},{_answer}");
        
        //return _content;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_question} {_answer}");
    }
}