using System;

public class Animation
{
    public Animation()
    {

    }

    public void DisplayEllipsis()
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("     LOADING");
        for (int i = 0; i < 3; i++)
        {
            string text = string.Empty;
            for (int j = 0; j < 3; j++)
            {
                Thread.Sleep(500);
                text = ".";
                Console.Write($"{text}");
                Thread.Sleep(500);
            }
            Console.Write("\b\b\b   \b\b\b");
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        
    }
}