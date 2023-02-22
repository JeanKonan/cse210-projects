using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assign1 = new Assignment("Roberto Rodriguez", "Fractions");
        Console.WriteLine($"{Assign1.GetSummary()}");
        
        MathAssignment Math1 = new MathAssignment(Assign1.GetStudentName(), Assign1.GetTopic(), "7.3", "8-19");
        Console.WriteLine($"{Math1.GetHomeworkList()}");

        WritingAssignment Writing1 = new WritingAssignment(Assign1.GetStudentName(), Assign1.GetTopic(), "The causes of World War II");
        Console.WriteLine($"{Writing1.GetWritingInformation()}");
    }
}