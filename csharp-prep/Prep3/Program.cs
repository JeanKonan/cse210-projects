using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");

        //int number = int.Parse(Console.ReadLine());
        
        string answer="";
        
        do
        {
            int guess;
            int i=0;

            Random randomNb = new Random();
            int number = randomNb.Next(1,100);
            
            do
            {
                Console.Write("What is your guess? ");

                guess = int.Parse(Console.ReadLine());

                if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                i++;
            }
            while (number != guess);
            
            Console.WriteLine("Great! You've found it");
            
            if (i>1)
            {
                Console.WriteLine($"You guessed {i} times.");
            }
            else
            {
                Console.WriteLine($"You got it at your first try.");
            }

            Console.Write("Do you want to continue? (yes/no) ");
            answer = Console.ReadLine();
        }
        while (answer == "yes");
    }
}