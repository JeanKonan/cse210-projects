using System;

class Prompt
{
    public List<string> _question = new List<string>();

    public Prompt()
    {

    }

    public string Display()
    {
        Random question = new Random();
        int i = question.Next(_question.Count);

        return _question[i];
    }

}