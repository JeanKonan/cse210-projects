using System;

public class Seller: Person
{
    private Product _product = new Product();
    public Seller(Product product): base()
    {
        _product = product;
    }

    public void OfferProduct()
    {
        
    }
}