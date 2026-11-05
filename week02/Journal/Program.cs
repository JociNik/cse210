/*  EXCEEDING REQUIREMENTS:
    The program now dynamically computes and  shows the amounts of entries and words in the journal. */

using System;
using System.Net.Mail;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine();
        string input = "";

        while (input != "5")
        {
            journal.UpdateStatistics();
            Console.WriteLine($"Your journal currently has {journal._entryCount} entries and {journal._wordCount} words!");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            if (input == "1")
            {
                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(promptText);

                string entryText = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = promptText;
                newEntry._entryText = entryText;

                journal.AddEntry(newEntry);
                Console.WriteLine();
            }

            else if (input == "2")
            {
                foreach (Entry entry in journal._entries)
                {
                    entry.Display();
                }
                Console.WriteLine();
            }

            else if (input == "3")
            {
                Console.WriteLine("What is the filename?");
                input = Console.ReadLine();

                journal.LoadFromFile(input);
                Console.WriteLine();
            }

            else if (input == "4")
            {
                Console.WriteLine("What is the filename?");
                input = Console.ReadLine();

                journal.SaveToFile(input);
                Console.WriteLine();
            }
        }
    }
}