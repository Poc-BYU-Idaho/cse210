using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";
        Console.Write("What percent do you have in the class? ");
        string gradePercent = Console.ReadLine();
        float useableGradePercent = float.Parse(gradePercent);
        if (useableGradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (useableGradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (useableGradePercent >= 70)
        {
            letterGrade = "C";
        }
        else if (useableGradePercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is: {letterGrade}");
        if (useableGradePercent > 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class, but you can get it next time!");
        }
    }
}