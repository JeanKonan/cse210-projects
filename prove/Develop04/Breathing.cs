using System;

public class BreathingActivity: Activity
{
    public BreathingActivity(): base()
    {
        SetName("Breathing activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public override void Display()
    {
        int seconds = GetDuration();
        int x = 1;
        if (seconds % 10 <= 5 && seconds % 10 != 0)
        {
            Console.Write($"Breathe in...");
            this.CountDown(2);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            this.CountDown(3);
            Console.WriteLine("\n");
        }
        else if (seconds % 10 > 5)
        {
            x--;
        }

        while (x <= seconds/10)
        {
            Console.Write($"Breathe in...");
            this.CountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            this.CountDown(6);
            Console.WriteLine("\n");
            x++;
        }    
    }
}