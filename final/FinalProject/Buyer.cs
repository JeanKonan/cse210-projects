using System;

public class Buyer: Person
{
    private string _answer;
    private Stock _theStock;
    private Bid _myBid = new Bid();
    private Cart _myCart = new Cart();

    public Buyer():base()
    {

    }

    public float GetBidValue()
    {
        return _myBid.GetPrice();
    }

    public void SetBidValue(float price)
    {
        _myBid.SetPrice(price);
    }
    
    public float GetCartValue()
    {
        return _myCart.GetMinValue().GetPrice();
    }

    public void SetStock(Stock myStock)
    {
        _theStock = myStock;
    }

    public Stock GetStock()
    {
        return _theStock;
    }

    public void MakeBid(float price)
    {
        _myBid.SetPrice(price);
        Console.Write($"Do we have a deal for ${price}?(Yes/No)");
    }

    public void ApproveBid(float price)
    {
        _myBid.SetPrice(price);
    }

    public void Shop()
    {
        string reply = "yes";

        while (reply != "No")
        {
            Console.Write("Which article are you intered in? ");
            
            int index = int.Parse(Console.ReadLine())-1;
            string name = _theStock.GetStock()[index].GetName();
            int qte_left = _theStock.GetStock()[index].GetQuantity( );

            Console.Write($"How many {name} do you want? ");
            int qte = int.Parse(Console.ReadLine());

            while (qte_left < qte)
            {
                Console.Write($"Sorry! we are left with only {qte_left} {name}. Do you want them all? (Yes/No) ");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    qte = qte_left;
                }
                else
                {
                    Console.Write($"How many {name} do you want? ");
                }
            }
            _myCart.Add(_theStock.GetStock()[index], qte);
            _theStock.ReduceStock(index, qte);

            Console.Write("Do you want more articles?(Yes/No) ");
            reply = Console.ReadLine();
            Console.WriteLine();
        }
        
        _myCart.View();
    }

    public void Checkout()
    {
        Console.Clear();
        Console.WriteLine($"Here is your total: ${_myCart.GetTotal()}");
        Console.WriteLine();
    }
}