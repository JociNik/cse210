using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string letter = "F";
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }

        else if (gradePercentage >= 80)
        {
            letter = "B";
        }

        else if (gradePercentage >= 70)
        {
            letter = "C";
        }

        else if (gradePercentage >= 60)
        {
            letter = "D";
        }

        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        if (gradePercentage % 10 >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations. You passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time.");
        }

        Console.WriteLine($"Your grade is {letter}{sign}");
    }
}