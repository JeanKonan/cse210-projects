using System;

public class Buyer: Person
{
    private string _answer;
    private Stock _theStock;
    private List<Product> _articles = new List<Product>();
    private Cart myCart = new Cart();

    public Buyer():base()
    {

    }

    public void SetStock(Stock myStock)
    {
        _theStock = myStock;
    }

    public Stock GetStock()
    {
        return _theStock;
    }

    public void Shop()
    {
        //Stock theStock = new Stock();
        //theStock.StimulateStock();
        string reply = "yes";

        while (reply != "No")
        {
            Console.Write("Which article are you intered in? ");
            //Product article = new Product();
            
            int index = int.Parse(Console.ReadLine())-1;
            string name = _theStock.GetStock()[index].GetName();
            int qte_left = _theStock.GetStock()[index].GetQuantity( );
            //string name = _articles[index].GetName();

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
            myCart.Add(_theStock.GetStock()[index], qte);
            _theStock.ReduceStock(index, qte);

            Console.Write("Do you want more articles?(Yes/No) ");
            reply = Console.ReadLine();
            Console.WriteLine();
        }
        
        myCart.View();
    }

    public void Checkout()
    {
        Console.Clear();
        Console.WriteLine($"Here is your total: ${myCart.GetTotal()}");
        Console.WriteLine();
    }
}