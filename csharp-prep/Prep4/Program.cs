using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> nb_list = new List<int>();
        int nb=-1, lg_number=0, sm_number = 10000;
        float total = 0.0f;

        while (nb != 0)
        {
            Console.Write("Enter number: ");
            nb = int.Parse(Console.ReadLine());
            
            if (nb != 0)
            {
                nb_list.Add(nb);
            }

            if (sm_number > nb)
            {
                sm_number = nb;
            }

            if (lg_number < nb)
            {
                lg_number = nb;
            }
        }
    

        foreach (int numb in nb_list)
        {
            total += numb;
        }

        float average = total / (nb_list.Count);
        nb_list.Sort();

        Console.WriteLine($"The sum is: {total}.");
        Console.WriteLine($"The average is: {average.ToString("0.00")}.");
        Console.WriteLine($"The largest number is: {lg_number}.");
        Console.WriteLine($"The smallest number is: {sm_number}.");
        Console.Write("Sorted List: ");
        foreach (int numb in nb_list)
        {
            Console.Write($"{numb} ");
        }
        
    }
}