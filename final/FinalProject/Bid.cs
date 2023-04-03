using System;
public class Bid
{
    private float _price;

    public Bid()
    {

    }

    public float GetPrice()
    {
        return _price;
    }

    public void SetPrice(float price)
    {
        _price = price;
    }

    public void Update(float amount, int qte)
    {
        _price += amount*qte;
    }
}