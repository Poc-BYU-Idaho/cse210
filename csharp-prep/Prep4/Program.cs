using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int convertedInput = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (convertedInput != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            convertedInput = int.Parse(userInput);
            if (convertedInput != 0)
            {
                numbers.Add(convertedInput);
            }
        }
        numbers.Sort();
        float numberSum = 0;
        int greatestNumber = numbers.Last();
        int smallestPositive = -1;
        foreach (int number in numbers)
        {
            numberSum += number;
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The sum is: {numberSum}\nThe average is: {numberSum / numbers.Count}\nThe largest number is: {greatestNumber}\nThe smallest positive number is: {smallestPositive}");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}