using System;

class Program
{
    static void Main(string[] args)
    {
        int user_input = 0;
        List<string> myContent = new List<string>();
        string fileName = "";
        Journal myJournal = new Journal();

        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What do you want to do? ");

            user_input = int.Parse(Console.ReadLine());

            Prompt myQuestions = new Prompt();

            if (user_input == 1)
            {

                Entry new_entry = new Entry();
                new_entry._question = myQuestions.Display();

                Console.Write($"{new_entry._question} ");
                new_entry._answer = Console.ReadLine();
                new_entry._date = DateTime.Now;
                new_entry.Hold(myContent);
            } 
            else if (user_input == 2)
            {
                myJournal.Display();
            }
            else if (user_input == 3)
            {
                Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                myJournal.Load(fileName);
            }
            else if (user_input == 4)
            {
                myJournal.Save(fileName, myContent);
            }
        }
        while (user_input != 5);
        
    }
}