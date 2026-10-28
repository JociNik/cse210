using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string input;
        int intInput = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        while (intInput != 0)
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            intInput = int.Parse(input);
            numbers.Add(intInput);
        }


        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");


        float average;
        average = ((float)sum) / numbers.Count();

        Console.WriteLine($"The average is {average}");


        int largestNum = 0;

        foreach (int number in numbers)
        {
            if (number > largestNum) { largestNum = number; }
        }

        Console.WriteLine($"The largest number is: {largestNum}");
    }
}