using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string gradeInText = Console.ReadLine();
        int grade = int.Parse(gradeInText);
        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
            if (grade < 93)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            if (grade < 83)
            {
                letterGrade += "-";
            }
            else if (grade >= 87)
            {
                letterGrade += "+";
            }
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            if (grade < 73)
            {
                letterGrade += "-";
            }
            else if (grade >= 77)
            {
                letterGrade += "+";
            }
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            if (grade < 63)
            {
                letterGrade += "-";
            }
            else if (grade >= 67)
            {
                letterGrade += "+";
            }
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("Well done! You've passed the class'");
        }
        else 
        {
            Console.Write("Sorry! You will have to retake the class.");
        }
    }
}