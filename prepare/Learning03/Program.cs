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

            string quest1 = "Who was the most interesting person I interacted with today?";
            string quest2 = "What was the best part of my day?";
            string quest3 = "How did I see the hand of the Lord in my life today?";
            string quest4 = "What was the strongest emotion I felt today?";
            string quest5 = "If I had one thing I could do over today, what would it be?";

            Prompt myQuestions = new Prompt();
            myQuestions._question.Add(quest1);
            myQuestions._question.Add(quest2);
            myQuestions._question.Add(quest3);
            myQuestions._question.Add(quest4);
            myQuestions._question.Add(quest5);

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