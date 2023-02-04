using System;

class Prompt
{
    public List<string> _question = new List<string>{
        "What are your plans for this weekend?",
        "What is the best book you have read recently?",
        "How have you grown this year?",
        "What are the most important life lessons you have learned?",
        "Have trouble sleeping? What's keeping you up?",
        "What is the last dream you remember?",
        "What are your biggest fears?",
        "Do you have a fear that is stopping you from achieving your goals?",
        "What would you do if you were granted three wishes?",
        "How about if you were given five wishes?",
        "What was the last show you went to?",
        "Do you have a secret talent you are hiding?",
        "What is your biggest regret?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What 5 things are you grateful for this week?",
        "Which people in your life are you most grateful for?",
        "When were you last surprised?",
        "What is the most exhilarating thing that has happened to you this year?",
        "How can you show gratitude more?",
        "What are 3 things that have happened to you which were difficult but you are now grateful for the experience?"
    };

    //public Prompt()
    //{

    //}

    public string Display()
    {
        Random question = new Random();
        int i = question.Next(_question.Count);

        return _question[i];
    }

}