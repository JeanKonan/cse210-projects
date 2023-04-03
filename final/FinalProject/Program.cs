using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "2";
        Menu myMenu = new Menu();
        
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
                Thread.Sleep(3000);
                myMenu.End();
            }
            else if (reply == "2")
            {
                Seller mySeller = new Seller();
                Negociation newNegociation = new Negociation();
                string response = string.Empty;
                float newPrice = 0;
                newNegociation.Start();
                mySeller.SetBidValue(customer.GetCartValue());
                customer.SetBidValue(newNegociation.GetBid());

                while (mySeller.GetBidValue() >= customer.GetBidValue())
                {
                    Console.Write("Please make a better bid ");
                    newPrice = float.Parse(Console.ReadLine());
                    customer.MakeBid(newPrice);
                }

                while (mySeller.GetBidValue() < customer.GetBidValue() && response != "Yes")
                {
                    Console.Write("Here the new bid I can offer you: $");
                    newPrice = float.Parse(Console.ReadLine());
                    mySeller.MakeBid(newPrice);
                    response = Console.ReadLine();
                    if (response == "No")
                    {
                        Console.Write("Please make a better bid ");
                        newPrice = float.Parse(Console.ReadLine());
                        customer.MakeBid(newPrice);
                        response = Console.ReadLine();
                    }
                }

                mySeller.SetBidValue(newPrice);
                customer.SetBidValue(newPrice);
                mySeller.ApproveBid(mySeller.GetBidValue());
                customer.ApproveBid(mySeller.GetBidValue());
                Console.Clear();
                Console.WriteLine($"Here is the amount you need to pay: {mySeller.GetBidValue()}");
                newNegociation.End();
                Thread.Sleep(3000);
                myMenu.End();
            }
        }
            
    }
}