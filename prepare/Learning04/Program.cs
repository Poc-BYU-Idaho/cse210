using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment firstAssignment = new Assignment("Joe", "test");
        Console.WriteLine(firstAssignment.GetSummary());

        MathAssignment secondAssignment = new MathAssignment("Jim", "Math", "7.5", "1-19");
        Console.WriteLine(secondAssignment.GetSummary());
        Console.WriteLine(secondAssignment.GetHomeworkList());

        WritingAssignment thirdAssignment = new WritingAssignment("Jack", "English", "War and Peace");
        Console.WriteLine(thirdAssignment.GetSummary());
        Console.WriteLine(thirdAssignment.GetWritingInformation());
    }
}