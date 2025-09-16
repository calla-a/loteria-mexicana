using System;
using System.Formats.Asn1;
using Journal;

// Added "mood", included in the Entry class. Before the prompt, the program will ask the user for their feelings
// Added confirmation messages when saving and loading files. Additionally, if the user enters the name of a file
// that does not exist when loading, they will be advised about it
// Created a CreateEntry method to the Journal class for cleaner code.
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.AddPrompt();
        Journal.Journal journal = new Journal.Journal();

        Console.WriteLine("Welcome to your Journal Program");
        Console.WriteLine("Please select one of the following options:");
        string answer;
        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                journal.CreateEntry(promptGenerator);
            }
            else if (answer == "2")
            {
                journal.DisplayAll();
            }
            else if (answer == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (answer == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
        } while (answer != "5");
    }
}