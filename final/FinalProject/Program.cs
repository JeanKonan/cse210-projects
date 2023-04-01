using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "2";
        Menu myMenu = new Menu();
        //Stock myStock = new Stock();

        //myStock.StimulateStock();
        Buyer customer = new Buyer();
        customer.SetStock(myMenu.GetStock());
        myMenu.Start();

        while (answer == "2")
        {
            myMenu.Display();
            customer.Shop();
            myMenu.ShowOptions();
            answer = Console.ReadLine();
        }

        if (answer == "1")
        {
            
            List<string> menuOptions = new List<string>{"Enter account information", "Negociate"};
            myMenu.SetOptions(menuOptions);
            customer.Checkout();
            myMenu.ShowOptions();

            string reply = Console.ReadLine();

            if (reply == "1")
            {
                Console.Write($"Please enter your account information below:");
            }
            else if (reply == "2")
            {
                Negociation newNegociation = new Negociation();
                newNegociation.Start();
            }
        }
            
    }
}