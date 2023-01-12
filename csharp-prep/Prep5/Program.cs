using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqr_numb = SquareNumber(number);
        string result = DisplayResult(name, sqr_numb);

        Console.WriteLine($"{result}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your user name: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int usernum = int.Parse(Console.ReadLine());
        return usernum;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static string DisplayResult(string name, int number)
    {
        return $"Hi {name}, the square of your number is {number}.";
    }
}