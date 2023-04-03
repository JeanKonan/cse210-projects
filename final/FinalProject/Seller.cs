using System;

public class Seller: Person
{
    private Bid _myBid = new Bid();

    public Seller():base()
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

    public void MakeBid(float price)
    {
        Console.Write($"Do we have a deal for ${price}?(Yes/No)");
        /*string answer = Console.ReadLine();
        if (answer == "Yes")
        {
            this.SetBidValue(myPrice);
        }*/
    }

    public void ApproveBid(float price)
    {
        Console.WriteLine("We have a deal then");
        _myBid.SetPrice(price);
        Animation myAnim = new Animation();
        myAnim.DisplayEllipsis();
        Console.WriteLine("Proceed to enter account information");
    }
}