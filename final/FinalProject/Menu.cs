using System;

public class Menu
{
    private List<string> _options = new List<string>();
    private List<Product> _articles = new List<Product>();
    private Stock _myStock = new Stock();

    public Menu()
    {
        _options.Add("Checkout");
        _options.Add("Continue shopping");
        _myStock.StimulateStock();
    }

    public Stock GetStock()
    {
        return _myStock;
    }

    public void SetStock(Stock myStock)
    {
        _myStock = myStock;
    }

    public void SetOptions(List<string> opt)
    {
        _options = opt;
    }

    public void ShowOptions()
    {
        int i = 1;
        foreach (string option in _options)
        {
            Console.Write($"    {i}. {option} ");
            i++;
        }
    }

    public void Display()
    {

        Console.Clear();
        Console.WriteLine("We have:");
        
        _myStock.Display();
        Console.WriteLine();
        
    }

    public void End()
    {
        Console.Clear();
        Console.WriteLine("Thanks for shopping with FUNSHOPPING! See you soon!");
    }

    public void Start()
    {
        Animation myAnim = new Animation();

        Console.Clear();
        Console.WriteLine("Welcome to FUNSHOPPING");
        Console.WriteLine();
        Console.Write("Please press ENTER to see our articles ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.WriteLine();
            myAnim.DisplayEllipsis();
        }
        
    }

}