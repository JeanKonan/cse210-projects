using System;
public class Product
{
    private string _name;
    private int _quantity;
    private float _salesPrice;
    private Bid _minBid = new Bid();

    public Product()
    {

    }
    
    public Product(Bid minB)
    {
        _minBid = minB;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int qte)
    {
        _quantity = qte;
    }

    public float GetPrice()
    {
        return _salesPrice;
    }

    public void SetPrice(float sPrice)
    {
        _salesPrice = sPrice;
    }

    public Bid GetMinBid()
    {
        return _minBid;
    }

    public void SetMinBid(float price)
    {
        Bid myBid = new Bid();
        myBid.SetPrice(price);
        _minBid = myBid;
    }


    public void InsertProduct(string name, int qte, float price, float minB)
    {
        this.SetName(name);
        this.SetQuantity(qte);
        this.SetPrice(price);
        this.SetMinBid(minB);
    }

}