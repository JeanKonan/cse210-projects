using System;

class Program
{
    static void Main(string[] args)
    {
        string myChoice = string.Empty;
        
        while (myChoice != "4")
        {
            Menu menu = new Menu();
            menu.Display();

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            menu.SetChoice(choice);

            myChoice = menu.GetChoice();

            if (myChoice == "1")
            {
                Activity myActivity = new BreathingActivity();
                myActivity.Create();
                myActivity.Display();
                myActivity.Close();
            }
            else if (myChoice == "2")
            {
                Activity myActivity = new ReflectingActivity();
                myActivity.Create();
                myActivity.Display();
                myActivity.Close();
            }
            else if (myChoice == "3")
            {
                Activity myActivity = new ListingActivity();
                myActivity.Create();
                myActivity.Display();
                myActivity.Close();
            }
            else if (myChoice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please chose one of the options in the menu");
                choice = Console.ReadLine();
                menu.SetChoice(choice);
                myChoice = menu.GetChoice();
            }
        }
    }
}