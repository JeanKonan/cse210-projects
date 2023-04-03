using System;

public class Stock
{
    private List<Product> _content = new List<Product>();

    public Stock()
    {

    }

    public List<Product> GetStock()
    {
        return _content;
    }

    public void AddStock(string name, int qte, float price, float minB)
    {
        Product article = new Product();
        
        article.InsertProduct(name, qte, price, minB);
        _content.Add(article);
    }

    public void StimulateStock()
    {
        this.AddStock("Belt", 15, 17.20f, 15f);
        this.AddStock("Pants", 30, 32.45f, 25f);
        this.AddStock("Jacket", 11, 35.99f, 30f);
        this.AddStock("Shorts", 18, 23.90f, 18f);
        this.AddStock("Backpack", 8, 25.59f, 20.99f);
        this.AddStock("Shirt", 25, 30.20f, 24.99f);
    }

    public void ReduceStock( int index, int number)
    {
        int qte = _content[index].GetQuantity() - number;
        _content[index].SetQuantity(qte);
    }

    public void Display()
    {
        int i=1;
        foreach (Product article in _content)
        {
            string name = article.GetName();
            int qte = article.GetQuantity();
            float price = article.GetPrice();

            if (qte > 0)
            {
                Console.WriteLine($"    {i}. ({qte}) {name} ${price}");
                i++;
            }
            
        }
    }

}