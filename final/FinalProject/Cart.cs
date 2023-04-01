using System;

public class Cart
{
    private Dictionary<Product, int> _content = new Dictionary<Product, int>();
    private float _total;

    private Bid _minValue = new Bid();

    public Cart()
    {
        _total = 0;
        _minValue.SetPrice(0);
    }

    public Dictionary<Product, int> GetCart()
    {
        return _content;
    }

    public float GetTotal()
    {
        return _total;
    }

    public void SetTotal(float number)
    {
        _total = number;
    }

    public Bid GetMinValue()
    {
        return _minValue;
    }

    public void UpdateMinValue(float amount)
    {
        Bid myBid = new Bid();
        myBid.SetPrice(amount);
        _minValue = myBid;
    }

    public void Add(Product product, int qte)
    {
        _content.Add(product, qte);
        Console.WriteLine($"\"{qte} {product.GetName()}\" have been added to your cart.");
    }

    public void Remove(Product product)
    {
        _content.Remove(product);
        Console.WriteLine($"\"{product.GetName()}\" have been removed from your cart.");
    }

    public void View()
    {
        Console.Clear();
        int i = 1;
        Console.WriteLine("This is your cart: ");
        foreach (Product product in _content.Keys)
        {
            string name = product.GetName();
            int qte = _content[product];
            float price = product.GetPrice();
            Bid minVal = product.GetMinBid();

            _minValue.Update(minVal.GetPrice());
            
            Console.WriteLine($"    {i}-  {qte}*{name} = ${price*qte}");
            i++;
            _total += price*qte;
        }
    }

}