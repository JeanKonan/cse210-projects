using System;

public class Menu
{
    private List<string> _option = new List<string>{
        "Start breathing activity",
        "Start reflecting activity",
        "Start listing activity",
        "Quit"
    };
    private string _choice;

    public Menu()
    {

    }

    public string GetChoice()
    {
        return _choice;
    }

    public void SetChoice(string choice)
    {
        _choice = choice;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        int i=1;
        foreach (string option in _option)
        {
            Console.WriteLine($"    {i}. {option}");
            i++;
        }
    }

}