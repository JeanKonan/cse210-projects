using System;

public class ReflectingActivity: Activity
{
    List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(): base()
    {
        SetName("Reflecting activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Cancel(string sentence)
    {
        string _hidden_word = string.Empty;
        foreach (char letter in sentence)
        {
            if (letter != '.' || letter != ',' || letter != ';' || letter != ':' || letter != '!' || letter != '?')
            {
                _hidden_word += '_';
            }
        }
        sentence = _hidden_word;
    }

    public void GenerateQuestion()
    {
        Random _quest = new Random();
        int n = _quest.Next(_questions.Count);

        while (_questions[n][0] == '_')
        {
            n = _quest.Next(_questions.Count);
        }
        Console.Write($"> {_questions[n]} ");
        this.Cancel(_questions[n]);
        this.Pause();
    }

    public void GeneratePrompt()
    {
        Random _randPr = new Random();
        int nb = _randPr.Next(_prompts.Count);

        Console.WriteLine($"-- {_prompts[nb]} --");
        Console.WriteLine();
        Console.Write("When you have something on your mind, press enter to continue. ");
        //string response = Console.ReadLine();

        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.WriteLine("\n");

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
            Console.Write("You may begin in: ");
            this.CountDown(5);

            int seconds = GetDuration();

            Console.Clear();
            for (int i = 0; i < seconds/10; i++)
            {
                Thread.Sleep(1000);
                this.GenerateQuestion();
                Thread.Sleep(1000);
            }
        }
    }

    public override void Display()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        this.GeneratePrompt();
        Console.WriteLine("\n");
        
    }
}