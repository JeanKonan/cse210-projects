using System;

public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(): base()
    {
        SetName("Listing activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GeneratePrompt()
    {
        Random _randPr = new Random();
        int nb = _randPr.Next(_prompts.Count);

        return $"--- {_prompts[nb]} ---";
    }

    public override void Display()
    {
        int items = 0;
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(this.GeneratePrompt());
        Console.Write("You may begin in: ");
        this.CountDown(5);
        Console.WriteLine();
        string response = string.Empty;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this.GetDuration());
        
        do
        {
            Console.Write("> ");
            response = Console.ReadLine();
            items++;
        }
        while (DateTime.Now <= futureTime && response != "");
        
        Console.WriteLine();
        Console.WriteLine($"You have listed {items} items!\n");
    }

    public void Spin()
    {
        int i=0;
        while (i < 5)
        {
            Console.Write("\\");
            Thread.Sleep(333);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(333);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(333);
            Console.Write("\b");
            i++;
        }

        Console.Write(" ");
        Console.WriteLine("\b");
    }
    
    public override void Close()
    {
        this.DisplayEndMsg();
        this.Spin();
    }

    public override void DisplayEndMsg()
    {
        Console.WriteLine("Well done!");
        this.Spin();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}.");
    }

    public override void Pause()
    {
        int i=5;
        while (i > 0)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
            i--;
        }
        
        Console.Write(" ");
        Console.Write("\b");
    }
}