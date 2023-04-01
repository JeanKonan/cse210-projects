using System;

public class Person
{
    private string _name;
    private Bid _currentBid = new Bid();

    public Person()
    {

    }

    public Person(Product product)
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

    public Bid MakeBid()
    {
        return _currentBid;
    }

    public Bid CounterBid(Bid myNewBid)
    {
        return myNewBid;
    }

    public Boolean Consider(Boolean isAccepted = false)
    {
        return isAccepted;
    }
}