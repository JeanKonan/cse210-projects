using System;

public class Negociation
{
    private Bid _myBid = new Bid();
    public Negociation()
    {

    }

    public float GetBid()
    {
        return _myBid.GetPrice();
    }

    public void Start()
    {
        Console.Write("Please make a bid then ");
        _myBid.SetPrice(float.Parse(Console.ReadLine()));
    }

    public void End()
    {
        Console.WriteLine("Enter your account information to complete the checkout");
    }
}