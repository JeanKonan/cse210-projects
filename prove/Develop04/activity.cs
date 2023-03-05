using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {

    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(string duration)
    {
        _duration = int.Parse(duration);
    }

    public void DisplayStartMsg()
    {
        Console.Clear();
        Console.WriteLine($"Welcome in the {GetName()}.");
        Console.WriteLine();
        Console.WriteLine($"{GetDescription()}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        SetDuration(Console.ReadLine());
    }

    public virtual void Display()
    {

    }

    public void Create()
    {
        this.DisplayStartMsg();
        Console.Clear();
        Console.WriteLine("Get ready...");
        this.Pause();
    }

    public virtual void Close()
    {
        this.DisplayEndMsg();
        this.Pause();
    }

    public virtual void DisplayEndMsg()
    {
        Console.WriteLine("Well done!");
        this.Pause();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}.");
    }

    public virtual void Pause()
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

    public void CountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b");
            seconds--;
        }
        
        Console.Write(" ");
        Console.Write("\b");
    }

}